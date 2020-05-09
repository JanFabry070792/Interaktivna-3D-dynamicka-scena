/*
 * Projekt je nastavený a odladený pre platformu x86 a .NET 4.0
 * Ukážka obsahuje vytvorenie objektu Device a SwapChain spoločne jednou metódou CreateWithSwapChain a použitie komponentu Timer pre animáciu objektu
 * Alt+Enter pre celoobrazovkový mód nefunguje v DXGI pre WinForms
*/

using System;
using System.Drawing;
using System.Windows.Forms;
using SlimDX;
using SlimDX.Direct3D11;
using DX11 = SlimDX.Direct3D11;
using DXGI = SlimDX.DXGI;

namespace gsU2_Priezvisko_Meno
{
    public struct Camera
    {
        public float camHorizontal;
        public float camVertical;
        public float camZoom;
    }
    public partial class Form1 : Form
    {
        //Deklarácie globálnych premenných
        private DX11.Device m_device;                       //Zariadenie D3D11
        private DX11.DeviceContext m_deviceContext;         //Kontext zariadenia
        private DX11.RenderTargetView m_renderTarget;       //Cieľ renderovania
        private DXGI.SwapChain m_swapChain;
        private DXGI.SwapChainDescription m_swapChainDesc;
        private bool m_initialized;                         //Pomocná premenná s návratovou hodnotou inicializačnej metódy
        private bool m_started = false;                     
        private SimpleObject m_simpleBox;
        //Transformačné matice
        private Matrix m_viewMatrix;
        private Matrix m_projMatrix;
        private Matrix m_worldMatrix;
        private Matrix m_viewProjMatrix;

        private float angle;                               //Premenná pre animáciu objektu


        // Pre vytvorenie zariadenia akceptujeme DX10 a vyššiu verziu adaptéra
        FeatureLevel[] m_levels = {
                            FeatureLevel.Level_11_0,
                            FeatureLevel.Level_10_1,
                            FeatureLevel.Level_10_0
                                };

        public Camera camView;
        public Form1()
        {
            InitializeComponent();
            this.panelVykresli.MouseWheel += panelVykresli_MouseWheel;
            this.SetStyle(ControlStyles.ResizeRedraw, true);          //Nastavenie správania sa okna ap.
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetCamera(ref camView);
            panelVykresli.TabIndex = 0;
            cbCw.SelectedIndex = 0;
            cbObject.SelectedIndex = 0;
            
        }

        // Inicializácia zariadenia a ďalších potrebných zdrojov pre rendering. Metóda vráti true, ak skončí bez chyby.
        private bool Initialize3D()
        {
            try
            {
                //Vytvorenie objektu typu SwapChainDescription a nastavenie jeho vlastností 
                m_swapChainDesc = new DXGI.SwapChainDescription();
                m_swapChainDesc.OutputHandle = panelVykresli.Handle;
                m_swapChainDesc.IsWindowed = true;
                m_swapChainDesc.BufferCount = 1;
                m_swapChainDesc.Flags = DXGI.SwapChainFlags.AllowModeSwitch;
                m_swapChainDesc.ModeDescription = new DXGI.ModeDescription(
                    panelVykresli.Width,
                    panelVykresli.Height,
                    new Rational(60, 1),
                    DXGI.Format.R8G8B8A8_UNorm);
                m_swapChainDesc.SampleDescription = new DXGI.SampleDescription(1, 0);
                m_swapChainDesc.SwapEffect = DXGI.SwapEffect.Discard;
                m_swapChainDesc.Usage = DXGI.Usage.RenderTargetOutput;

                ///Vytvorenie objektu zariadenie a SwapChain spoločne jednou metódou
                DX11.Device.CreateWithSwapChain(
                    DriverType.Warp,                //Typ renderovacieho zariadenia: SW renderer: Reference, Warp, Hardware - hardvérový renderer:  http://slimdx.org/tutorials/DeviceCreation.php
                    DeviceCreationFlags.None,       //Žiadne extra návestia
                    m_levels,                       //Kompatibilita s verziami DX  
                    m_swapChainDesc,                //Objekt typu SwapChainDescription
                    out m_device,                   //vráti Direct3D zariadenie reprezentujúce virtuálny graf. HW
                    out m_swapChain);               //vráti SwapChain pre prácu s baframi

                //Vytvorenie zobrazovacej plochy - celé okno ap.
                var m_viewPort = new Viewport(0.0f, 0.0f, panelVykresli.Width, panelVykresli.Height);

                //Vytvorenie objektu zadného bafra a cieľa renderovania
                DX11.Texture2D m_backBuffer = Texture2D.FromSwapChain<Texture2D>(m_swapChain, 0);
                m_renderTarget = new RenderTargetView(m_device, m_backBuffer);

                m_deviceContext = m_device.ImmediateContext;   //Nastavenie kontextu zariadenia, ktorý obsahuje nastavenia pre D3D zariadenie, tu priame renderovanie bez vytvárania príkazového zoznamu. Pozri: http://msdn.microsoft.com/en-us/library/windows/desktop/ff476880%28v=vs.85%29.aspx 
                m_deviceContext.Rasterizer.SetViewports(m_viewPort);  //Nastavenie zobrazovacej plochy
                m_deviceContext.OutputMerger.SetTargets(m_renderTarget);  //Nastavenie cieľa renderovania
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba počas inicializácie Direct3D11: \n" + ex.Message);
                m_initialized = false;
            }

            return m_initialized;
        }

        

        // Volanie inicializačnej metódy na udalosť okna OnLoad
        protected override void OnLoad(EventArgs e)
        {
            //base.OnLoad(e);
            Initialize3D();
        }

        Color colorPozadie = new Color();
        protected void RenderAll() //Slúži na opätované renderovanie objektu po úpravách
        {
            m_deviceContext.ClearRenderTargetView(m_renderTarget, new Color4(colorPozadie));
            m_simpleBox.Render(m_device, m_worldMatrix, m_viewProjMatrix);
            m_swapChain.Present(0, DXGI.PresentFlags.None);
        }

        private void SetCamera(ref Camera cam) // nastavenie kamery
        {
            cam.camHorizontal = 0;
            cam.camVertical = 0;
            cam.camZoom = -3;
        }


        protected override void OnPaint(PaintEventArgs e)
        {


            if (m_initialized)
            {
                RenderAll();
            }
        }
        

        Boolean osXOb = false;   // pomocné premenné pre definovanie rotácie
        Boolean osYOb = false;
        Boolean osZOb = false;
        Boolean osX = false;
        Boolean osY = false;
        Boolean osZ = false;
        private void renderTimer_Tick_1(object sender, EventArgs e)
        {
            if (m_initialized)
            {
                m_simpleBox = new SimpleObject(cbObject.Text);
                m_simpleBox.LoadResources(m_device);   //Zavedenie zdrojov používateľskou metódou

                //Nastavenie uhľa rotácie v závislosti od času behu aplikácie
                int time = Environment.TickCount / 10 % 1000;            //Čas v msek od spustenia ap.-umožňuje nastaviť rýchlosť animácie  
                if (cbCw.SelectedIndex == 0)
                {
                    angle = (float)(time * (2.0f * Math.PI) / 1000.0f);
                }
                else if (cbCw.SelectedIndex == 1)
                {
                    angle = (float)(-(time * (2.0f * Math.PI) / 1000.0f));
                }


                //Nastavenie transformačných matíc 

                Matrix rotOsX, rotOsY, rotOsZ, rotObjX, rotObjY, rotObjZ;
                if (osX == true)
                {
                    rotOsX = Matrix.Translation(0, 2, 0) * Matrix.RotationX(angle);
                }
                else
                {
                    rotOsX = Matrix.Translation(0, 0, 0) * Matrix.RotationX(0);
                }
                if (osY == true)
                {
                    rotOsY = Matrix.Translation(0, 0, 2) * Matrix.RotationY(angle);
                }
                else
                {
                    rotOsY = Matrix.Translation(0, 0, 0) * Matrix.RotationY(0);
                }
                if (osZ == true)
                {
                    rotOsZ = Matrix.Translation(2, 0, 0) * Matrix.RotationZ(angle);
                }
                else
                {
                    rotOsZ = Matrix.Translation(0, 0, 0) * Matrix.RotationZ(0);
                }
                if (osXOb == true)
                {
                    rotObjX = Matrix.Translation(0, 0, 0) * Matrix.RotationX(angle);
                }
                else
                {
                    rotObjX = Matrix.Translation(0, 0, 0) * Matrix.RotationX(0);
                }
                if (osYOb == true)
                {
                    rotObjY = Matrix.Translation(0, 0, 0) * Matrix.RotationY(angle);
                }
                else
                {
                    rotObjY = Matrix.Translation(0, 0, 0) * Matrix.RotationY(0);
                }
                if (osZOb == true)
                {
                    rotObjZ = Matrix.Translation(0, 0, 0) * Matrix.RotationZ(angle);
                }
                else
                {
                    rotObjZ = Matrix.Translation(0, 0, 0) * Matrix.RotationZ(0);
                }
                m_worldMatrix = rotOsX * rotOsY * rotOsZ * rotObjX * rotObjY * rotObjZ;
                

                //Definovanie pohľadu na scénu: transformácia z WCS do súradnicového systému kamery
                m_viewMatrix = Matrix.LookAtLH(
                     new Vector3(camView.camHorizontal, camView.camVertical, camView.camZoom),       //poloha kamery
                     new Vector3(0f, 0f, 1f),        //smer pohľadu kamery
                     new Vector3(0f, 1f, 0f));       //tzv. UpVector definujúci smer hore

                //Definovanie typu premietania pohľadu scény
                m_projMatrix = Matrix.PerspectiveFovLH((float)Math.PI * 0.5f, panelVykresli.Width / (float)panelVykresli.Height, 0.1f, 100f);

                //Výsledná zobrazovacia matica
                
                m_viewProjMatrix = m_viewMatrix * m_projMatrix;
                m_deviceContext.ClearRenderTargetView(m_renderTarget, new Color4(colorPozadie));   //Farba pozadia pre renderovac9 cieľ - tu okno
                m_simpleBox.Render(m_device, m_worldMatrix, m_viewProjMatrix);                    //Volanie používateľskej metódy Render
                m_swapChain.Present(0, DXGI.PresentFlags.None);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panelVykresli.Width = this.Width - panelVykresli.Location.X - 50;
            panelVykresli.Height = this.Height - panelVykresli.Location.Y - 100;
            if (m_started)
                RenderAll();
        }

        private void btnStart_Click(object sender, EventArgs e) // spustenie animácie
        {
            renderTimer.Start();
        }

        private void btnVykresli_Click(object sender, EventArgs e) // Vykreslenie objektu na zobrazovaciu plochu
        {
            renderTimer.Stop();
            m_viewMatrix = Matrix.LookAtLH(
                 new Vector3(camView.camHorizontal, camView.camVertical, camView.camZoom),       //poloha kamery
                 new Vector3(0f, 0f, 1f),        //smer pohľadu kamery
                 new Vector3(0f, 1f, 0f));       //tzv. UpVector definujúci smer hore

            m_projMatrix = Matrix.PerspectiveFovLH((float)Math.PI * 0.5f, panelVykresli.Width / (float)panelVykresli.Height, 0.1f, 100f);

            //Výsledná zobrazovacia matica
            m_viewProjMatrix = m_viewMatrix * m_projMatrix;


            //Natočenie objektu
            m_worldMatrix = Matrix.RotationYawPitchRoll(0.5f, 0.0f, 0.0f);  //(rot. okolo osi y, rot. okolo osi x,rot okolo osi z)  

            m_simpleBox = new SimpleObject(cbObject.Text);
            m_simpleBox.LoadResources(m_device);   //Zavedenie zdrojov používateľskou metódou
            m_initialized = true;
        }

        private void btnStop_Click(object sender, EventArgs e)  // zastavenie animácie
        {
            renderTimer.Stop();
        }

        private void btnVycisti_Click(object sender, EventArgs e) // Vyčistenie zobrazovacej plochy
        {
            panelVykresli.Invalidate();
            renderTimer.Stop();
            m_initialized = false;
        }

        private void cbFarbaPozadia_SelectedIndexChanged(object sender, EventArgs e)  // zmena farby pozadia pomocou comboboxu
        {
            if(cbFarbaPozadia.SelectedItem.Equals("Čierna"))
            {
                colorPozadie = Color.Black;
            }
            else if (cbFarbaPozadia.SelectedItem.Equals("Červená"))
            {
                colorPozadie = Color.Red;
            }
            else if (cbFarbaPozadia.SelectedItem.Equals("Modrá"))
            {
                colorPozadie = Color.Blue;
            }
            else if (cbFarbaPozadia.SelectedItem.Equals("Biela"))
            {
                colorPozadie = Color.White;
            }
            else if (cbFarbaPozadia.SelectedItem.Equals("Žltá"))
            {
                colorPozadie = Color.Yellow;
            }
            else if (cbFarbaPozadia.SelectedItem.Equals("Zelená"))
            {
                colorPozadie = Color.Green;
            }
        }

       

        private void chXOb_CheckedChanged(object sender, EventArgs e) // zmena rotácie pomocou checkboxu
        {
            if (chXOb.Checked == true)
            {
                osXOb = true;
            }
            else
            {
                osXOb = false;
            }
        }

        private void chYOb_CheckedChanged(object sender, EventArgs e)
        {
            if (chYOb.Checked == true)
            {
                osYOb = true;
            }
            else
            {
                osYOb = false;
            }
        }

        private void chZOb_CheckedChanged(object sender, EventArgs e)
        {
            if (chZOb.Checked == true)
            {
                osZOb = true;
            }
            else
            {
                osZOb = false;
            }
        }

        private void chX_CheckedChanged(object sender, EventArgs e)
        {
            if (chX.Checked == true)
            {
                osX = true;
            }
            else
            {
                osX = false;
            }
        }

        private void chY_CheckedChanged(object sender, EventArgs e)
        {
            if (chY.Checked == true)
            {
                osY = true;
            }
            else
            {
                osY = false;
            }
        }

        private void chZ_CheckedChanged(object sender, EventArgs e)
        {
            if (chZ.Checked == true)
            {
                osZ = true;
            }
            else
            {
                osZ = false;
            }
        }

        void panelVykresli_MouseWheel(object sender, MouseEventArgs e) // približovanie pomocou kolieska na myši
        {
            if(m_initialized)
            {
                camView.camZoom += float.Parse(Math.Round(((decimal)e.Delta) / 100, 0).ToString());
                SetupWorldMatrix();
                RenderAll();
            }
            
        }

        private void panelVykresli_MouseMove(object sender, MouseEventArgs e)
        {
            panelVykresli.Focus();
        }



        public void SetupWorldMatrix()
        {
            m_viewMatrix = Matrix.LookAtLH(new Vector3(camView.camHorizontal, camView.camVertical, camView.camZoom), new Vector3(0f, 0f, 1f), new Vector3(0f, 1f, 0f));
            m_projMatrix = Matrix.PerspectiveFovLH((float)Math.PI * 0.5f, panelVykresli.Width / (float)panelVykresli.Height, 0.1f, 100f);
            m_viewProjMatrix = m_viewMatrix * m_projMatrix;
            RenderAll();
        }

        private void cbObject_SelectedIndexChanged(object sender, EventArgs e)  // Výber druhu objektu pre zobrazenie
        {
            renderTimer.Stop();
            panelVykresli.Invalidate();
            renderTimer.Stop();
            m_initialized = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)  // Skrytie tlačidla "Vykresliť" pri zmene tabu
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                btnVykresli.Visible = false;
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                btnVykresli.Visible = true;
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
            {
                btnVykresli.Visible = false;
            }
        }
    }
}

using System.Runtime.InteropServices;   //Používa atribút StructLayout
using SlimDX;

namespace gsU2_Priezvisko_Meno
{
    [StructLayout(LayoutKind.Sequential)]  //Atribút def. pre Vertex sekvenčné usporiadanie položiek
    public struct Vertex
    {
        public Vector3 Position;
        public int Color;

        public Vertex(Vector3 position, int color)
        {
            this.Position = position;
            this.Color = color;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public static class ListAlbum
    {
        private static List<Album> _albuns = new List<Album>();

        public static List<Album> listalbuns()
        {
            return _albuns;
        }

        public static void AddAlbum(this Album Album)
        {
            _albuns.Add(Album);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLibrary
{
    public class TextureData
    {
        #region Ctor

        public TextureData()
        {

        }
        public TextureData(string fileName)
        {
            _Data =  GLHelper.LoadTexture(fileName, out _Width, out _Height);
        }

        #endregion

        #region Private Fields

        private float[] _Data;
        private int _Width;
        private int _Height;

        #endregion

        #region Private Properties

        public float[] Data { get => _Data; set => _Data = value; }
        public int Width { get => _Width; set => _Width = value; }
        public int Height { get => _Height; set => _Height = value; }

        #endregion

    }
}

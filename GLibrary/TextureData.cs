using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLibrary
{
    public enum eTextureDataType
    {
        BMP = 0,
        Float = 1
    }

    public enum eTextureExtension
    {
        BMP = 0,
        JPG = 1,
        PNG = 2

    }

    public class TextureData
    {
        #region Ctor

        public TextureData()
        {

        }

        public TextureData(string fileName, eTextureDataType TextureDataType)
        {
            if (TextureDataType == eTextureDataType.Float)
            {
                _Data =  GLHelper.LoadTexture(fileName, out _Width, out _Height);
            }
            else if(TextureDataType == eTextureDataType.BMP)
            {
                _Bmp = GLHelper.ConvertToBitmap(fileName);
                _Width = _Bmp.Width;
                _Height = _Bmp.Height;
            }
        }

        #endregion

        #region Private Fields

        private float[] _Data;
        private Bitmap _Bmp;
        private int _Width;
        private int _Height;

        #endregion

        #region Public Properties

        public float[] Data { get => _Data; set => _Data = value; }
        public Bitmap Bmp{ get => _Bmp; set => _Bmp = value; }
        public int Width { get => _Width; set => _Width = value; }
        public int Height { get => _Height; set => _Height = value; }

        #endregion

    }
}

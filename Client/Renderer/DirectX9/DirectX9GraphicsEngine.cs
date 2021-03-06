//------------------------------------------------------------------------------  
//      Copyright (c) Microsoft Corporation.  All rights reserved.                                                             
//------------------------------------------------------------------------------

using System;
using System.Drawing;
using Terrarium.Renderer.Engine;

namespace Terrarium.Renderer.DirectX9
{
    /// <summary>
    /// 
    /// </summary>
    public class DirectX9GraphicsEngine : IGraphicsEngine
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        public Rectangle GetWindowRect(IntPtr handle)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        public void SetFullScreenMode(IntPtr handle)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        public void SetWindow(IntPtr handle)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public IGraphicsSurface CreateSurface(int width, int height)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="fullScreen"></param>
        /// <param name="doubleBuffer"></param>
        /// <returns></returns>
        public IGraphicsSurface CreatePrimarySurface(IntPtr handle, bool fullScreen, bool doubleBuffer)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public IGraphicsSurface CreateWorkSurface(int width, int height)
        {
            throw new NotImplementedException();
        }
    }
}
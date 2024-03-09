using AnimatedImageTest.Avalonia.Xamls;
using ApprovalTests.Reporters;
using ApprovalTests;
using Avalonia;
using Avalonia.Media.Imaging;
using NUnit.Framework;
using UnitTest.Base.Utils;
using UnitTest.Base;
using System;
using Avalonia.Controls;
using System.Diagnostics;
using Avalonia.Threading;
using System.Threading.Tasks;

namespace AnimatedImageTest.Avalonia
{
    public class UnitTest1 : UnitTestBase
    {
        private UserControl? _control;

        public override Control ContentOfWindow => _control ??= new UserControl1();

        [Test]
        [RunOnUI]
        public void Test1()
        {
            var ctrl = ContentOfWindow;

            var width = ctrl.Bounds.Width;
            var height = ctrl.Bounds.Height;
            var renderSize = new PixelSize((int)width, (int)height);
            var bitmap = new RenderTargetBitmap(renderSize, new Vector(96, 96));
            bitmap.Render(ctrl);
        }
    }
}
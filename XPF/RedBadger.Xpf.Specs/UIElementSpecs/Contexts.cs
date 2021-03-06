#region License
/* The MIT License
 *
 * Copyright (c) 2011 Red Badger Consulting
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
*/
#endregion

//-------------------------------------------------------------------------------------------------
// <auto-generated> 
// Marked as auto-generated so StyleCop will ignore BDD style tests
// </auto-generated>
//-------------------------------------------------------------------------------------------------

#pragma warning disable 169
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local

namespace RedBadger.Xpf.Specs.UIElementSpecs
{
    using Machine.Specifications;

    using Moq;
    using Moq.Protected;

    using RedBadger.Xpf.Adapters.Xna.Graphics;
    using RedBadger.Xpf.Controls;
    using RedBadger.Xpf.Graphics;

    public abstract class a_UIElement
    {
        protected const string ArrangeOverride = "ArrangeOverride";

        protected const string MeasureOverride = "MeasureOverride";

        protected static Mock<UIElement> Subject;

        private Establish context = () => Subject = new Mock<UIElement> { CallBase = true };
    }

    public abstract class a_Measured_UIElement : a_UIElement
    {
        protected const string VisualOffset = "VisualOffset";

        protected static readonly Size availableSize = new Size(100, 100);

        protected static readonly Size desiredSize = new Size(100, 100);

        private Establish context = () =>
            {
                Subject.Protected().Setup<Size>(MeasureOverride, ItExpr.Is<Size>(size => size.Equals(availableSize))).
                    Returns(desiredSize);
                Subject.Object.Measure(availableSize);
            };
    }

    public abstract class a_Measured_and_Arranged_UIElement : a_Measured_UIElement
    {
        protected static readonly Size finalSize = new Size(100, 100);

        private Establish context = () =>
            {
                Subject.Protected().Setup<Size>(ArrangeOverride, ItExpr.IsAny<Size>()).Returns(finalSize);
                Subject.Object.Arrange(new Rect(finalSize));
            };
    }

    public abstract class a_UIElement_in_a_RootElement : a_UIElement
    {
        protected static Mock<Renderer> Renderer;

        protected static Mock<RootElement> RootElement;

        private Establish context = () =>
            {
                var viewPort = new Rect(30, 40, 200, 200);

                Renderer = new Mock<Renderer>(new Mock<ISpriteBatch>().Object, new Mock<IPrimitivesService>().Object)
                    {
                       CallBase = true 
                    };

                RootElement = new Mock<RootElement>(viewPort, Renderer.Object) { CallBase = true };
                RootElement.Object.Content = Subject.Object;
            };
    }
}

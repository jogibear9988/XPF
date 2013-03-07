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

#if MONOTOUCH
using RxThickness = System.Reactive.MonoTouch.StructWrapper<RedBadger.Xpf.Thickness>;
#else
using RxThickness = RedBadger.Xpf.Thickness;
#endif

namespace RedBadger.Xpf.Controls
{
    using RedBadger.Xpf.Controls.Primitives;

    public class Button : ButtonBase
    {
        public static readonly ReactiveProperty<RxThickness> PaddingProperty =
            ReactiveProperty<RxThickness>.Register("Padding",
                                                   typeof (Button),
                                                   new Thickness(),
                                                   ReactivePropertyChangedCallbacks.InvalidateMeasure);

        public Thickness Padding
        {
            get
            {
                return this.GetValue(PaddingProperty);
            }

            set
            {
                this.SetValue(PaddingProperty, value);
            }
        }

        public override void OnApplyTemplate()
        {
            if (this.Content != null)
            {
                this.Content.Margin = this.Padding;
            }
        }
    }
}

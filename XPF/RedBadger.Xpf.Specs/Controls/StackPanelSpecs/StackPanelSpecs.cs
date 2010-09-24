//-------------------------------------------------------------------------------------------------
// <auto-generated> 
// Marked as auto-generated so StyleCop will ignore BDD style tests
// </auto-generated>
//-------------------------------------------------------------------------------------------------

#pragma warning disable 169
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local

namespace RedBadger.Xpf.Specs.Controls.StackPanelSpecs
{
    using Machine.Specifications;

    using Moq;

    using RedBadger.Xpf.Controls;
    using RedBadger.Xpf.Graphics;

    using It = Machine.Specifications.It;

    public abstract class a_StackPanel
    {
        protected static StackPanel StackPanel;

        private Establish context = () => StackPanel = new StackPanel();
    }

    public abstract class a_StackPanel_with_2_children : a_StackPanel
    {
        protected const double ElementHeight = 100;

        protected const double ElementWidth = 200;

        protected static readonly Size AvailableSize = new Size(500, 500);

        protected static Mock<UIElement> Child1;

        protected static Mock<UIElement> Child2;

        private Establish context = () =>
            {
                Child1 = new Mock<UIElement> { CallBase = true };
                Child2 = new Mock<UIElement> { CallBase = true };

                Child1.Object.Width = Child2.Object.Width = ElementWidth;
                Child1.Object.Height = Child2.Object.Height = ElementHeight;

                StackPanel.Children.Add(Child1.Object);
                StackPanel.Children.Add(Child2.Object);
            };
    }

    public abstract class a_measured_StackPanel_with_2_children : a_StackPanel_with_2_children
    {
        private Establish context = () => StackPanel.Measure(AvailableSize);
    }

    public abstract class a_Measured_and_Arranged_StackPanel : a_StackPanel
    {
        protected static RootElement RootElement;

        protected static Mock<ISpriteFont> SpriteFont;

        private Establish context = () =>
            {
                SpriteFont = new Mock<ISpriteFont>();
                RootElement = new RootElement(new Rect(new Size(100, 100)), new Mock<IRenderer>().Object)
                    {
                       Content = StackPanel 
                    };

                RootElement.Update();
            };
    }

    [Subject(typeof(StackPanel), "Layout")]
    public class when_measured_with_vertical_orientation : a_StackPanel_with_2_children
    {
        private Because of = () =>
            {
                StackPanel.Orientation = Orientation.Vertical;
                StackPanel.Measure(AvailableSize);
            };

        private It should_have_a_bigger_desired_height =
            () => StackPanel.DesiredSize.Height.ShouldEqual(ElementHeight * 2);

        private It should_have_the_same_desired_width = () => StackPanel.DesiredSize.Width.ShouldEqual(ElementWidth);
    }

    [Subject(typeof(StackPanel), "Layout")]
    public class when_measured_with_horizontal_orientation : a_StackPanel_with_2_children
    {
        private Because of = () =>
            {
                StackPanel.Orientation = Orientation.Horizontal;
                StackPanel.Measure(AvailableSize);
            };

        private It should_have_a_bigger_desired_width = () => StackPanel.DesiredSize.Width.ShouldEqual(ElementWidth * 2);

        private It should_have_the_same_desired_height = () => StackPanel.DesiredSize.Height.ShouldEqual(ElementHeight);
    }

    [Subject(typeof(StackPanel), "Layout")]
    public class when_arranged_with_vertical_orientation : a_measured_StackPanel_with_2_children
    {
        private Because of = () =>
            {
                StackPanel.Orientation = Orientation.Vertical;
                StackPanel.Arrange(new Rect(AvailableSize));
            };

        private It should_layout_the_2nd_child_at_the_same_horizontal_position =
            () => Child2.Object.VisualOffset.X.ShouldEqual(Child1.Object.VisualOffset.X);

        private It should_layout_the_2nd_child_below_the_first =
            () => Child2.Object.VisualOffset.Y.ShouldEqual(Child1.Object.VisualOffset.Y + ElementHeight);
    }

    [Subject(typeof(StackPanel), "Layout")]
    public class when_arranged_with_horizontal_orientation : a_measured_StackPanel_with_2_children
    {
        private Because of = () =>
            {
                StackPanel.Orientation = Orientation.Horizontal;
                StackPanel.Arrange(new Rect(AvailableSize));
            };

        private It should_layout_the_2nd_child_at_the_same_vertical_position =
            () => Child2.Object.VisualOffset.Y.ShouldEqual(Child1.Object.VisualOffset.Y);

        private It should_layout_the_2nd_child_to_the_right_of_the_first =
            () => Child2.Object.VisualOffset.X.ShouldEqual(Child1.Object.VisualOffset.X + ElementWidth);
    }

    [Subject(typeof(StackPanel))]
    public class when_orientation_is_changed : a_Measured_and_Arranged_StackPanel
    {
        private Because of = () => StackPanel.Orientation = Orientation.Horizontal;

        private It should_invalidate_arrange = () => StackPanel.IsArrangeValid.ShouldBeFalse();

        private It should_invalidate_measure = () => StackPanel.IsMeasureValid.ShouldBeFalse();
    }
}
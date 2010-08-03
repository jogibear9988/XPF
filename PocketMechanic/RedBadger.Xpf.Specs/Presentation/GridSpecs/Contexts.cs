﻿//-------------------------------------------------------------------------------------------------
// <auto-generated> 
// Marked as auto-generated so StyleCop will ignore BDD style tests
// </auto-generated>
//-------------------------------------------------------------------------------------------------

#pragma warning disable 169
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local

namespace RedBadger.Xpf.Specs.Presentation.GridSpecs
{
    using Machine.Specifications;

    using Moq;

    using RedBadger.Xpf.Presentation;
    using RedBadger.Xpf.Presentation.Controls;

    public abstract class a_Grid
    {
        protected static Grid Grid;

        private Establish context = () => Grid = new Grid();
    }

    public abstract class a_Grid_with_two_rows_and_two_columns : a_Grid
    {
        protected static readonly Size AvailableSize = new Size(200, 200);

        protected static Mock<UIElement> BottomLeftChild;

        protected static Mock<UIElement> BottomRightChild;

        protected static ColumnDefinition ColumnOneDefinition;

        protected static ColumnDefinition ColumnTwoDefinition;

        protected static RowDefinition RowOneDefinition;

        protected static RowDefinition RowTwoDefinition;

        protected static Mock<UIElement> TopLeftChild;

        protected static Mock<UIElement> TopRightChild;

        private Establish context = () =>
            {
                ColumnOneDefinition = new ColumnDefinition();
                Grid.ColumnDefinitions.Add(ColumnOneDefinition);

                ColumnTwoDefinition = new ColumnDefinition();
                Grid.ColumnDefinitions.Add(ColumnTwoDefinition);

                RowOneDefinition = new RowDefinition();
                Grid.RowDefinitions.Add(RowOneDefinition);

                RowTwoDefinition = new RowDefinition();
                Grid.RowDefinitions.Add(RowTwoDefinition);

                TopLeftChild = new Mock<UIElement> { CallBase = true };
                TopLeftChild.Object.Width = 50;
                TopLeftChild.Object.Height = 60;
                TopLeftChild.Object.HorizontalAlignment = HorizontalAlignment.Left;
                TopLeftChild.Object.VerticalAlignment = VerticalAlignment.Top;
                Grid.SetColumn(TopLeftChild.Object, 0);
                Grid.SetRow(TopLeftChild.Object, 0);

                TopRightChild = new Mock<UIElement> { CallBase = true };
                TopRightChild.Object.Width = 70;
                TopRightChild.Object.Height = 80;
                TopRightChild.Object.HorizontalAlignment = HorizontalAlignment.Left;
                TopRightChild.Object.VerticalAlignment = VerticalAlignment.Top;
                Grid.SetColumn(TopRightChild.Object, 1);
                Grid.SetRow(TopRightChild.Object, 0);

                BottomLeftChild = new Mock<UIElement> { CallBase = true };
                BottomLeftChild.Object.Width = 10;
                BottomLeftChild.Object.Height = 20;
                BottomLeftChild.Object.HorizontalAlignment = HorizontalAlignment.Left;
                BottomLeftChild.Object.VerticalAlignment = VerticalAlignment.Top;
                Grid.SetColumn(BottomLeftChild.Object, 0);
                Grid.SetRow(BottomLeftChild.Object, 1);

                BottomRightChild = new Mock<UIElement> { CallBase = true };
                BottomRightChild.Object.Width = 30;
                BottomRightChild.Object.Height = 40;
                BottomRightChild.Object.HorizontalAlignment = HorizontalAlignment.Left;
                BottomRightChild.Object.VerticalAlignment = VerticalAlignment.Top;
                Grid.SetColumn(BottomRightChild.Object, 1);
                Grid.SetRow(BottomRightChild.Object, 1);

                Grid.Children.Add(TopLeftChild.Object);
                Grid.Children.Add(TopRightChild.Object);
                Grid.Children.Add(BottomLeftChild.Object);
                Grid.Children.Add(BottomRightChild.Object);
            };
    }
}
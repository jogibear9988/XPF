//-------------------------------------------------------------------------------------------------
// <auto-generated> 
// Marked as auto-generated so StyleCop will ignore BDD style tests
// </auto-generated>
//-------------------------------------------------------------------------------------------------

#pragma warning disable 169
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local

namespace RedBadger.Xpf.Specs.Presentation.VectorSpecs
{
    using System;

    using Machine.Specifications;

    [Subject(typeof(Vector))]
    public class when_a_vector_is_asked_for_its_length
    {
        private static double result;

        private static Vector subject;

        private Establish context = () => subject = new Vector(20, 30);

        private Because of = () => result = subject.Length;

        private It should_return_the_correct_length =
            () => result.ShouldEqual(Math.Sqrt(subject.X * subject.X + subject.Y * subject.Y));
    }

    [Subject(typeof(Vector))]
    public class when_a_vector_is_asked_for_its_length_squared
    {
        private static double result;

        private static Vector subject;

        private Establish context = () => subject = new Vector(20, 30);

        private Because of = () => result = subject.LengthSquared;

        private It should_return_the_correct_length =
            () => result.ShouldEqual(subject.X * subject.X + subject.Y * subject.Y);
    }

    [Subject(typeof(Vector))]
    public class when_a_vector_is_multiplied
    {
        private static Vector result;

        private static Vector subject;

        private Establish context = () => subject = new Vector(20, 30);

        private Because of = () => result = subject * 5d;

        private It should_have_the_correct_X_component = () => result.X.ShouldEqual(100d);

        private It should_have_the_correct_Y_component = () => result.Y.ShouldEqual(150d);
    }

    [Subject(typeof(Vector))]
    public class when_a_vector_is_divided
    {
        private static Vector result;

        private static Vector subject;

        private Establish context = () => subject = new Vector(20, 30);

        private Because of = () => result = subject / 5d;

        private It should_have_the_correct_X_component = () => result.X.ShouldEqual(4d);

        private It should_have_the_correct_Y_component = () => result.Y.ShouldEqual(6d);
    }

    [Subject(typeof(Vector))]
    public class when_a_vector_is_normalized
    {
        private static Vector subject;

        private Establish context = () => subject = new Vector(20, 30);

        private Because of = () => subject.Normalize();

        private It should_have_a_unit_length = () => subject.Length.ShouldEqual(1);
    }

    [Subject(typeof(Vector))]
    public class when_caluculating_the_cross_product
    {
        private static double result;

        private static Vector vector1;

        private static Vector vector2;

        private Establish context = () =>
            {
                vector1 = new Vector(20, 30);
                vector2 = new Vector(15, 25);
            };

        private Because of = () => result = Vector.CrossProduct(vector1, vector2);

        private It should_give_the_correct_result =
            () => result.ShouldEqual(vector1.X * vector2.Y - vector1.Y * vector2.X);
    }

    [Subject(typeof(Vector))]
    public class when_caluculating_the_dot_product
    {
        private static double result;

        private static Vector vector1;

        private static Vector vector2;

        private Establish context = () =>
            {
                vector1 = new Vector(20, 30);
                vector2 = new Vector(15, 25);
            };

        private Because of = () => result = Vector.DotProduct(vector1, vector2);

        private It should_give_the_correct_result =
            () => result.ShouldEqual(vector1.X * vector2.X + vector1.Y * vector2.Y);
    }

    [Subject(typeof(Vector))]
    public class when_caluculating_the_angle_between_two_right_angle_vectors
    {
        private static double result;

        private static Vector vector1;

        private static Vector vector2;

        private Establish context = () =>
            {
                vector1 = new Vector(1, 0);
                vector2 = new Vector(0, 1);
            };

        private Because of = () => result = Vector.AngleBetween(vector1, vector2);

        private It should_give_the_correct_result = () => result.ShouldEqual(90);
    }

    [Subject(typeof(Vector))]
    public class when_caluculating_the_angle_between_two_vectors_at_45_degrees
    {
        private static double result;

        private static Vector vector1;

        private static Vector vector2;

        private Establish context = () =>
            {
                vector1 = new Vector(1, 0);
                vector2 = new Vector(1, 1);
            };

        private Because of = () => result = Vector.AngleBetween(vector1, vector2);

        private It should_give_the_correct_result = () => result.ShouldEqual(45);
    }
}
namespace CocusExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var message1 = new MessageA();
            message1.Handle();

            var message2 = new MessageB();
            message2.Handle();

            var message3 = new MessageC();
            message3.Handle();
        }
    }

    public abstract class Message
    {
        public abstract void Handle();
    }

    public class MessageA : Message
    {
        public override void Handle()
        {
            MyCustomMethodOnA();
        }

        public void MyCustomMethodOnA() 
        {
            Console.WriteLine("MyCustomMethodOnA");
        }
    }

    public class MessageB : Message
    {
        public override void Handle()
        {
            MyCustomMethodOnB();
            SomeAdditionalMethodOnB();
        }

        public void MyCustomMethodOnB()
        {
            Console.WriteLine("MyCustomMethodOnB");
        }

        public void SomeAdditionalMethodOnB() 
        {
            Console.WriteLine("SomeAdditionalMethodOnB");
        }
    }

    public class MessageC : Message
    {
        public override void Handle()
        {
            MyCustomMethodOnC();
        }

        public void MyCustomMethodOnC() 
        {
            Console.WriteLine("MyCustomMethodOnC");
        }
    }
}

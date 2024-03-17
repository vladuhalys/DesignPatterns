
namespace Pattern_3.TemplateMethod
{
    public class ClientCode
    {
        public void Main()
        {
            try
            {
                Console.WriteLine("Template Method Pattern");
                Console.WriteLine("Stack Collection");
                StackCollection<int> stack = new StackCollection<int>();
                stack.AddToBack(1);
                stack.AddToBack(2);
                stack.AddToBack(3);
                Console.WriteLine(stack.GetFromBack());
                stack.RemoveFromBack();
                Console.WriteLine(stack.GetFromBack());
                Console.WriteLine("Queue Collection");
                QueueCollection<int> queue = new QueueCollection<int>();
                queue.AddToBack(1);
                queue.AddToBack(2);
                queue.AddToBack(3);
                Console.WriteLine(queue.GetFromFront());
                queue.RemoveFromFront();
                Console.WriteLine(queue.GetFromFront());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.TargetSite}: {ex.Message}");
            }
        }
    }
}

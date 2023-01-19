
namespace BinarySearchPro
{
    //Generic class where T is IComparable
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }


        //creating get set method for lefttree and righttree
        public BinarySearchTree<T> leftTree { get; set; }
        public BinarySearchTree<T> rightTree { get; set; }

        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.rightTree = null;
            this.leftTree = null;

        }

        //defining variables
        int leftCount = 0, rightCount = 0;
        bool result = false;

        //Creating Add method where parameter as T 

        public void Add(T item)
        {
            T root = this.NodeData;

            if (root.CompareTo(item) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new BinarySearchTree<T>(item);

                }
                else
                    this.leftTree.Add(item);
            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new BinarySearchTree<T>(item);
                }
                else
                    this.rightTree.Add(item);
            }
        }

        //Display method to add elements in respective position

        public void Display()
        {
            Console.WriteLine(this.NodeData.ToString());

            if (this.leftTree != null)
            {
                this.leftCount++;
                Console.Write("On Left Tree :");
                this.leftTree.Display();
            }

            if (this.rightTree != null)
            {
                this.rightCount++;
                Console.Write("On Right Tree :");
                this.rightTree.Display();
            }
        }
    }
}

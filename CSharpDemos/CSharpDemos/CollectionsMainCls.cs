using System;
using System.Collections;
using System.Text;

namespace CSharpDemos
{
    public class CollectionsMainCls
    {
        static void Main(string[] args)
        {
            bool bContinue = true;
            //bool bContinueCollection = true;
            object obj = null;
            QueueCls ObjCollection = new QueueCls();

            while (bContinue)
            {
                //Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Collections");
                Console.WriteLine("Press 1 to AddItems");
                Console.WriteLine("Press 2 to RemoveItems");
                Console.WriteLine("Press 3 to Display");
                Console.WriteLine("Press 4 to Change Collection");

                int x = Convert.ToInt32(Console.ReadLine());


                switch (x)
                {

                    case 1:
                        Console.WriteLine("Enter the Item to be Added");
                        obj = (object)Console.ReadLine();
                        ObjCollection.AddItem(obj);

                        break;
                    case 2:

                        obj = ObjCollection.RemoveItem();
                        Console.WriteLine(obj + "Item Removed from Collection Object");
                        break;

                    case 3:
                        Console.WriteLine("Collection Has these Following Items");
                        ObjCollection.Display();
                        break;
                    case 4:
                        bContinue = false;
                        break;
                    default:
                        Console.WriteLine("Enter a Valid  Value");
                        break;
                }
                Console.ReadLine();
            
            }
        }
    }



    public class StackCls
    {
        #region StackCls
        Stack objStack = null;
        public StackCls()
        {
            objStack = new Stack();
        }

        public void AddItem(object obj)
        {
            objStack.Push(obj);
        }

        public object RemoveItem()
        {
            if (objStack.Count > 0)
            {
                return objStack.Pop();
            }
            else
            {
                return "No Items Found in the stack";
            }
        }

        public void Display()
        {
            IEnumerator StackEnum = objStack.GetEnumerator(); //Getting the Enumerator
            StackEnum.Reset(); //Position at the Beginning
            while (StackEnum.MoveNext())
            {
                Console.WriteLine(StackEnum.Current.ToString());
            }
        }

        #endregion StackCls

    }


    public class QueueCls
    {
        #region QueueCls

        Queue objQueue = null;
        public QueueCls()
        {
            objQueue = new Queue();
        }

        public void AddItem(object obj)
        {
            objQueue.Enqueue(obj);
        }

        public object RemoveItem()
        {
            if (objQueue.Count > 0)
            {
                return objQueue.Dequeue();
            }
            else
            {
                return "No Items Found in the Queue";
            }
        }

        public void Display()
        {
            IEnumerator QueueEnum = objQueue.GetEnumerator(); //Getting the Enumerator
            QueueEnum.Reset(); //Position at the Beginning
            while (QueueEnum.MoveNext())
            {
                Console.WriteLine(QueueEnum.Current.ToString());
            }
        }
        #endregion QueueCls
    }

    public class ALCollectionsMainCls
    {
        static void Main(string[] args)
        {
            ArrayListCls ObjAl = new ArrayListCls();

            bool bContinue = true;
            //bool bContinueCollection = true;
            object obj = null;
            //QueueCls ObjCollection = new QueueCls();

            while (bContinue)
            {
                //Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Collections");
                Console.WriteLine("Press 1 to AddItems");
                Console.WriteLine("Press 2 to RemoveItems");
                Console.WriteLine("Press 3 to RemoveItemsAt");
                Console.WriteLine("Press 4 to Display");
                Console.WriteLine("Press 5 to Change Collection");

                int x = Convert.ToInt32(Console.ReadLine());


                switch (x)
                {

                    case 1:
                        Console.WriteLine("Enter the Item to be Added");
                        obj = (object)Console.ReadLine();
                        ObjAl.AddItem(obj);

                        break;
                    case 2:
                        Console.WriteLine("Enter the Item to be Removed");
                        obj = (object)Console.ReadLine();
                        ObjAl.RemoveItem(obj);
                        Console.WriteLine(obj + " :Item Removed from Collection Object");
                        break;
                    case 3:
                        Console.WriteLine("Enter the Indexvalue to remove Item from Collection Object");
                        int y = Convert.ToInt32(Console.ReadLine());
                        ObjAl.RemoveItemAt(y);
                        Console.WriteLine("Item at the Index '"+ y +"'Removed from Collection Object");
                        break;
                    case 4:
                        Console.WriteLine("Collection Has these Following Items");
                        ObjAl.Display();
                        break;
                    case 5:
                        bContinue = false;
                        break;
                    default:
                        Console.WriteLine("Enter a Valid  Value");
                        break;
                }
                Console.ReadLine();
            }

        }
    }

    public class ArrayListCls
    {
        #region ArrayListCls

        ArrayList objArrayList = null;
        public ArrayListCls()
        {
            objArrayList = new ArrayList();
        }

        public void AddItem(object obj)
        {
            objArrayList.Add(obj);
        }

        public void RemoveItem(object obj)
        {
            if (objArrayList.Count > 0)
            {
                objArrayList.Remove(obj);
            }
            else
            {
                Console.WriteLine("No Items Found in the ArrayList");
            }
        }

        public void RemoveItemAt(int x)
        {
            if (objArrayList.Count > x)
            {
                //Zero'th Based Index
                objArrayList.RemoveAt(x);
            }
            else
            {
                Console.WriteLine("No Items Found in the ArrayList");               
            }
        }

        public void Display()
        {
            IEnumerator ALEnum = objArrayList.GetEnumerator(); //Getting the Enumerator
            ALEnum.Reset(); //Position at the Beginning
            while (ALEnum.MoveNext())
            {
                Console.WriteLine(ALEnum.Current.ToString());
            }
        }
        #endregion ArrayListCls
    }

    public class HTCollectionsMainCls
    {
        static void Main(string[] args)
        {
            HashTableCls ObjHT = new HashTableCls();

            bool bContinue = true;
            //bool bContinueCollection = true;
            object objKey = null;
            object objItem = null;

            //QueueCls ObjCollection = new QueueCls();

            while (bContinue)
            {
                //Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Collections");
                Console.WriteLine("Press 1 to AddItems");
                Console.WriteLine("Press 2 to RemoveItems");
                Console.WriteLine("Press 3 to Display");
                Console.WriteLine("Press 4 to Exit Collection");

                int x = Convert.ToInt32(Console.ReadLine());


                switch (x)
                {

                    case 1:
                        Console.WriteLine("Enter the Item Key to be Added");
                        objKey = (object)Console.ReadLine();
                        Console.WriteLine("Enter the Item Value to be Added");
                        objItem = (object)Console.ReadLine();
                        ObjHT.AddItem(objKey,objItem);

                        break;
                    case 2:
                        Console.WriteLine("Enter the Item key to Remove Corresponding Item");
                        objKey = (object)Console.ReadLine();
                        ObjHT.RemoveItem(objKey);
                        Console.WriteLine(objKey + " :Item Removed from Collection Object");
                        break;
                    case 3:
                        Console.WriteLine("Collection Has these Following Items");
                        ObjHT.Display();
                        break;
                    case 4:
                        bContinue = false;
                        break;
                    default:
                        Console.WriteLine("Enter a Valid  Value");
                        break;
                }
                Console.ReadLine();
            }

        }
    }

    public class HashTableCls
    {
        Hashtable objHashtable = null;

        public HashTableCls()
        {
            objHashtable = new Hashtable();
        }

        public void AddItem(object objKey, object objItem)
        {
            objHashtable.Add(objKey,objItem);
        }

        public void RemoveItem(object objKey)
        {
            if (objHashtable.Count > 0)
            {
                objHashtable.Remove(objKey);
            }
            else
            {
                Console.WriteLine("No Items Found in the HashTable");
            }
        }

        public void Display()
        {
            IDictionaryEnumerator HTEnum = objHashtable.GetEnumerator(); //Getting the Enumerator
            HTEnum.Reset(); //Position at the Beginning
            while (HTEnum.MoveNext())
            {
                //Console.WriteLine(objHashtable[].ToString());
                Console.WriteLine(HTEnum.Key.ToString());
                Console.WriteLine(HTEnum.Value.ToString());

            }
        }
        

    }
}
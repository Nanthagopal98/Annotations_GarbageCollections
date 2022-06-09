using Annotations_And_Garbage_Collection;

Console.WriteLine("1 - To Run Annotations\n2 - To Run Garbage Collections");
int select = Convert.ToInt32(Console.ReadLine());
switch (select)
{
    case 1:
        {
            NewAtteribute.printAtteributes(typeof(Annotations_And_Garbage_Collection.Students));
            Console.WriteLine();
            NewAtteribute.printAtteributes(typeof(Annotations_And_Garbage_Collection.Terachers));
            Console.WriteLine();
            break;
    }
    case 2:
        {
            DisposableResourceHolder disposableResourceHolder = new DisposableResourceHolder();
            disposableResourceHolder.Dispose();
            Annotations_And_Garbage_Collection.Garbage_Collection garbageCollection = new Annotations_And_Garbage_Collection.Garbage_Collection();
            garbageCollection.Collector();
            break;
        }
}



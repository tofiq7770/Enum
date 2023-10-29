using Enum;
using Enum.Helpers;

//string email = Console.ReadLine();

// bool result=email.CheckEmail();

//if (result == true)
//{
//    Console.WriteLine("success");
//}
//else
//{
//    Console.WriteLine("wrong");
//}

//Console.WriteLine("Please add your email:");
//string email = Console.ReadLine();

//vaboolr res = email.CheckTrim(@" ");

//if (res == true)
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}

//Person person = new Person();
//person.Name = "Cavid";
//person.Surname = "Bashirov";

//Console.WriteLine(person.GetFullName());

//int[] numbers = { 1, 2, 3, 4, 5 };
//Console.WriteLine(numbers.MultipleOfNums());


//IntList list = new IntList();

//list.Add(1);
//list.Add(2);
//list.Add(100);

//list.GetAll();

//StringList list = new StringList();

//list.Add("Oruc");
//list.Add("Semed");
//list.Add("Nurlan");

//list.GettAll();

//PersonList list = new PersonList();

//list.Add(new Person { Id = 1, Name = "test1", Surname = "test1" });
//list.Add(new Person { Id = 2, Name = "test2", Surname = "test2" });
//list.Add(new Person { Id = 3, Name = "test3", Surname = "test3" });

//list.GetAll();


//DataList<int> datas = new();
//datas.Add(1);
//datas.Add(2);
//datas.Add(20);
//datas.GetAll();

//DataList<string> datas = new();
//datas.Add("sdasd");
//datas.Add("sads");

//datas.GetAll();

//DataList<Person> students = new();

//students.Add(new Person { Id = 1, Name = "test1", Surname = "test1" });
//students.Add(new Person { Id = 2, Name = "test1", Surname = "test1" });

////students.GetAll();

//var res = students.GetAll();
//foreach (Person item in res)
//{
//    Console.WriteLine(item.Name);
//    //}

//    Repository<string> repo1 = new Repository<string>();
//    Repository<int> repo1 = new Repository<int>();
//    Repository<Person> repo3 = new Repository<Person>();
//    Repository<Person, string> test = new Repository<Person, string>();
//    Repository<Person, BaseEntity> test = new Repository<Person, BaseEntity>();

//    DataList<string> words = new DataList<string>();
//    words.Add("salam1");
//    words.Add("salam2");
//    words.Add("salam3");



//    var datas = words.GetAll();
//    foreach (var item in datas)
//    {
//        Console.WriteLine(item);
//    }


//    Repository<Person> repository = new Repository<Person>();
//    repository.Add(new Person { Id = 1, Name = "test1", Surname = "test1" });

//    Repository<Student> repository1 = new Repository<Student>();

//    repository1.Add(new Student { Age = 19 });



//    string paymentType = "Cash";


//    static void CheckPaymentType(string type)
//    {
//        switch (type)
//        {
//            case nameof(PaymentType.Card):
//                Console.WriteLine("With Card");
//                break;
//            case nameof(PaymentType.Cash):
//                Console.WriteLine("With Cash");
//                break;

//            default:
//                Console.WriteLine("Payment is invalid");
//                break;

//        }



//        if (type == PaymentType.Card.ToString())
//        {
//            Console.WriteLine("With Card");

//        }
//        else if (type == PaymentType.Cash.ToString())
//        {
//            Console.WriteLine("With Cash");
//        }
//        else
//        {
//            Console.WriteLine("Payment type is wrong");
//        }

//    }
//    CheckPaymentType(paymentType);

using Data.Model;

namespace Data
{
    public class DataFactory : IDataFiller
    {
        public DataContext Fill()
        {
            DataContext data = new DataContext();

            data.customers.Add(new Customer("Kuba", "Avalon Hill", "arthur@imaking.uk", "(360) 6104514"));
            data.customers.Add(new Customer("Alex", "57536 Heffernan Parkway", "rfiddiman1@census.gov", "(601) 2223017"));
         
            data.customers.Add(new Customer("Tosia", "Camlann Place", "Tosia@killer.uk", "(726) 6714464"));
   
            data.customers.Add(new Customer("Basia", "Lake Avenue", "Basia@caliburn.uk", "(151) 9016881"));
    

            data.employees.Add(new Employee("Steve Harrington"));
            data.employees.Add(new Employee("Quentin Smith"));
            data.employees.Add(new Employee("Cheryl Mason"));
            data.employees.Add(new Employee("Laurie Strode"));
            data.employees.Add(new Employee("Zbyszek"));

            data.burgers.Add(new Burger("Angry Diablo Bacon King", 2.23f, "Diabelsko dobry", "/BurgerPhotos/1.png"));
            data.burgers.Add(new Burger("Angry Whopper", 2.00f, "Diabelski brat Bacon Kinga", "/BurgerPhotos/2.png"));
            data.burgers.Add(new Burger("Bacon King", 1.22f, "Zwykły król bekonu", "/BurgerPhotos/3.png"));
            data.burgers.Add(new Burger("Bacon Cheese Whopper", 26.18f, "Dla koneserów sera", "/BurgerPhotos/4.png"));
            data.burgers.Add(new Burger("Big King", 2.87f, "Duży król", "/BurgerPhotos/5.png"));
            data.burgers.Add(new Burger("Big-King-XXL", 1.55f, "Brat XXL dużego króla", "/BurgerPhotos/6.png"));
            data.burgers.Add(new Burger("CheeseTendercrisp", 2.21f, "Dla koneserów sera", "/burgerPhotos/7.png"));
            data.burgers.Add(new Burger("chicken_burger", 3.55f, "Kurcze pieczone", "/BurgerPhotos/8.png"));
            data.burgers.Add(new Burger("Chicken-Royal-Cheese", 2.30f, "Dla koneserów sera", "/BurgerPhotos/9.png"));
            data.burgers.Add(new Burger("Crispy-Chicken", 2.86f, "Kurcze pieczone", "/BurgerPhotos/10.png"));
            data.burgers.Add(new Burger("double_bacon_king", 2.21f, "Podwójny król boczku", "/BurgerPhotos/11.png"));
            data.burgers.Add(new Burger("Double-Cheeseburger", 3.74f, "Dla koneserów sera", "/BurgerPhotos/12.png"));
            data.burgers.Add(new Burger("Double-Whopper", 2.33f, "Podwójne natarcie", "/BurgerPhotos/13.png"));
            data.burgers.Add(new Burger("Steakhouse", 2.97f, "Mniam", "/BurgerPhotos/14.png"));

            return data;
        }
    }
}

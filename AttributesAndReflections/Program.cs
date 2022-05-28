// See https://aka.ms/new-console-template for more information
using AttributesAndReflections;
using System.Reflection;

var ogrenci = new Ogrenci();
ogrenci.Name = "Ahmet";
ogrenci.Id = 1;

GetTable();

void GetTable() {

    Type type = typeof(Ogrenci);

    //Console.WriteLine(type.Name);

    var tableAttr = type.GetCustomAttribute<TableAttribute>();

    //Console.WriteLine(tableAttr.TableName);  



    PropertyInfo[] propertyInfos = type.GetProperties();

    foreach (var item in tableAttr.TableName)
    {
        if (item == 'İ' || item == 'Ö' || item == 'ö' || item == 'ı' || item == 'Ü' || item == 'ü' )
        {
            Console.WriteLine("Table name Turkce karekter içeremez.");
            throw new Exception();

        }

    }

    Console.WriteLine($"Tablo Adi : {tableAttr.TableName}");
    Console.WriteLine("Kolonları: ");

    foreach (PropertyInfo propertyInfo in propertyInfos) {

        //Console.WriteLine(propertyInfo.Name );

        var attributesOfPropert = propertyInfo.CustomAttributes;

        foreach (var attribute in attributesOfPropert) {
            var attributeType = attribute.AttributeType;
            //Console.WriteLine(attributeType.Name ); 
        }

        var columnAttribute = propertyInfo.GetCustomAttribute<ColumnAttribute>();
        Console.WriteLine($"Kolon Adi : { columnAttribute.ColumnName}");
        Console.WriteLine($"Kolon Tipi : {columnAttribute._Type.Name}");
        Console.WriteLine($"Kolon zorunlu mu? : {columnAttribute.IsRequired}");

    }
 
   }

/* Una empresa de envío de mercancías, tiene un plan de tarifas y descuentos sobre el valor del envío de mercancía de sus clientes:

• Tarifas:
 Si el peso de la mercancía es inferior a 100 kg, la tarifa para el envío de ésta es de 20.000 pesos.
 Si el peso de la mercancía está entre 100 y 150 kg, la tarifa para el envío de ésta es de 25.000 pesos.
 Si el peso de la mercancía es superior a 150 kg y menor o igual a 200 kg, la tarifa para el envío de ésta es de 30.000
pesos.
 Si el peso de la mercancía es superior a 200 kg, la tarifa es de 35.000 pesos y además por cada 10 kg adicionales se paga
2.000 pesos.

• Descuentos:
 Si el valor de la mercancía está entre 300.000 y 600.000 pesos se hace un descuento del 10% sobre el valor del envío.
 Si el valor de la mercancía es superior a 600.000 pero menor o igual a 1.000.000 de pesos se hace un descuento del 20%
sobre el valor del envío.
 Si el valor de la mercancía es superior a 1.000.000 se hace un descuento del 30% sobre el valor del envío

• Promociones (solo hay dos tipos de pago):
 Si es día de promoción (lunes) y paga con tarjeta propia del almacén, sólo paga el 50% del costo de envío.
 Si paga en efectivo y el valor de la mercancía es superior a 1.000.000, sólo paga el 60% del costo de envío.

Si el cliente aplica a una promoción, no puede aplicar a un descuento. Se debe obtener el valor total del envío.
*/

using Reusable_code;

Console.WriteLine("----------------------------------");
Console.WriteLine("Programa para tarifas y descuentos");
Console.WriteLine("__________________________________");

/*var day = ConsoleExtension.GetString("Es Lunes [S]í [N]o:..............................");
var type = ConsoleExtension.GetString("Paga con [T]argeta o [E]fectivo:................");*/


var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
   var kilograms = ConsoleExtension.GetFloat("Ingresa el peso en kg de la mercancia......: ");
   var valueMerchandise = ConsoleExtension.GetDecimal("Ingrese el valor de la mercancia...........: ");
   var secondOptions = ConsoleExtension.GetChar("¿Es Lunes [S]í, [N]o?............................:");
   var payOptions = ConsoleExtension.GetChar("Paga en [E]fectivo o [T]argeta......................:");
   decimal fee = 0;
   int subtraction;
   decimal valueMoney = 0;
   decimal discount = 0;

    if (kilograms < 100)
    {
        fee = 20000M;
        valueMoney = fee;
    }
    if ((kilograms >= 100) && (kilograms <= 150))
    {
        fee = 25000M;
    }
    if ((kilograms > 150) && (kilograms <= 200))
    {
        fee = 30000M;
    }
    if (kilograms > 200)
    {
        subtraction = (int)(kilograms - 200) / 10 * 2000;
        fee = 35000M + subtraction;
    }
    Console.WriteLine($"La Tarifa es...............................: {fee:C2}");


    switch (secondOptions)
    {
        case 's':

            switch (payOptions)
            {
                case 'e':
                    if(valueMerchandise >= 300000 || (valueMerchandise <= 600000))
                    {
                        valueMoney = fee * 0.1M;
                        discount = fee - valueMoney;


                    }
                    if ((valueMerchandise > 600000) || (valueMerchandise <= 1000000))
                    {

                        valueMoney = fee * 0.2M;
                        discount = fee - valueMoney;

                    }
                    if (valueMerchandise > 1000000)
                    {

                        valueMoney = fee * 0.3M;
                        discount = fee - valueMoney;

                    }
                    Console.WriteLine($"El valor total del envío es.................: {valueMoney:C2}");
                    Console.WriteLine($"El descuento aplicado es......................: {discount:C2}");
                break;

                case 't':
                    valueMoney = fee * 0.5M;
                    discount = fee - valueMoney;
                    Console.WriteLine($"El valor total del envío es.................: {valueMoney:C2}");
                    Console.WriteLine($"El descuento aplicado es......................: {discount:C2}");
                break;
                default:

                    Console.WriteLine("Opción incorrecta");


                break;
            }

        break;

        case 'n':
          switch (payOptions)
          {
            case 'e':

                if (valueMerchandise > 1000000)
                {

                   valueMoney = fee * 0.6M;
                   discount = fee - valueMoney;

                }
                if (valueMerchandise >= 300000 || (valueMerchandise <= 600000))
                {
                    valueMoney = fee * 0.1M;
                    discount = fee - valueMoney;

                 
                }
                if ((valueMerchandise > 600000) || (valueMerchandise <= 1000000))
                {
                    valueMoney = fee * 0.2M;
                    discount = fee - valueMoney;

                }
                Console.WriteLine($"El valor total del envío es.................: {valueMoney:C2}");
                Console.WriteLine($"El descuento aplicado es......................: {discount:C2}");
            break;

            case 't':

               if (valueMerchandise >= 300000 || (valueMerchandise <= 600000))
               {
                   valueMoney = fee * 0.1M;
                   discount = fee - valueMoney;
               }
               if ((valueMerchandise > 600000) || (valueMerchandise <= 1000000))
               {

                  valueMoney = fee * 0.2M;
                  discount = fee - valueMoney;

               }
               if (valueMerchandise > 1000000)
               {

                  valueMoney = fee * 0.3M;
                  discount = fee - valueMoney;

               }
               Console.WriteLine($"El valor total del envío es.................: {valueMoney:C2}");
               Console.WriteLine($"El descuento aplicado es......................: {discount:C2}");

            break;

            default:

              Console.WriteLine("Opción incorrecta");   
                
            break;

          }     
        break;
        default:

            Console.WriteLine("Opción incorrecta");

        break;
    
    }
   do
   {
    answer = ConsoleExtension.GetValidOptions("¿Quieres seguir [S]í, [N]o?: ", options);
   }while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
}
while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase)) ;










/*
if (kilograms < 100)
{
    fee = 20000M;
    Console.WriteLine($"La Tarifa es...............................: {fee:C2}");
}
if ((kilograms >= 100) && (kilograms <= 150))
{
    fee = 25000M;
    Console.WriteLine($"La Tarifa es...............................: {fee:C2}");
}
if ((kilograms > 150) && (kilograms <= 200))
{
    fee = 30000M;
    Console.WriteLine($"La Tarifa es...............................: {fee:C2}");
}
if (kilograms > 200)
{
    subtraction = (int)(kilograms - 200) / 10 * 2000;
    fee = 35000M + subtraction;
    Console.WriteLine($"La Tarifa es...............................: {fee:C2}");
}
*/
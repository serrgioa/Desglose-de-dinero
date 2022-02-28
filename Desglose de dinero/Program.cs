static void desglose()
{
    int CAN, C100, C50, C20, C10, C5;
    CAN = C100 = C50 = C20 = C10 = C5 = 0;
    string linea;

    decimal cantidad_moneda;
    decimal TIPO_CAMBIO = 7.65m;

    Console.Write("Ingrese una cantidad en dolares:");
    linea = Console.ReadLine();

    cantidad_moneda = Convert.ToDecimal(linea);
   
    cantidad_moneda = (cantidad_moneda * TIPO_CAMBIO); 

    Console.WriteLine($"convirtiendo a Quetzales {cantidad_moneda}");

    CAN = Convert.ToInt32(Math.Truncate(cantidad_moneda));

    cantidad_moneda = (cantidad_moneda - CAN) * 100;
    Console.WriteLine($"Monedas = {cantidad_moneda}");
  
    if ((CAN >= 100))
    {
        C100 = (CAN / 100);
        CAN = CAN - (C100 * 100);
    }

    if ((CAN >= 50))
    {
        C50 = (CAN / 50);
        CAN = CAN - (C50 * 50);
    }

    if ((CAN >= 20))
    {
        C20 = (CAN / 20);
        CAN = CAN - (C20 * 20);
    }

    if ((CAN >= 10))
    {
        C10 = (CAN / 10);
        CAN = CAN - (C10 * 10);
    }

    if (CAN >= 5)
    {
        C5 = (CAN / 5);
        CAN = CAN - (C5 * 5);
    }

    Console.WriteLine($"ESTOS SON TUS BILLETES");
    Console.WriteLine($"BILLETES DE 100: {C100}");
    Console.WriteLine($"BILLETES DE 50: {C50}");
    Console.WriteLine($"BILLETES DE 20: {C20}");
    Console.WriteLine($"BILLETES DE 10: {C10}");
    Console.WriteLine($"BILLETES DE 5: {C5}");
    Console.WriteLine($"BILLETES DE 1: {CAN}");



    int MONE, MONE50, MONE25, MONE10, MONE5, MONE1;
    MONE = MONE50 = MONE25 = MONE10 = MONE5 = MONE1 = 0;
    MONE = Convert.ToInt32(cantidad_moneda);
    if ((MONE >= 50))
    {
        
        MONE50 = (MONE / 50);
        MONE = MONE - (MONE50 * 50);
    }

    if ((MONE >= 25))
    {
       
        MONE25 = (MONE / 25);
        MONE = MONE - (MONE25 * 25);
    }

    if ((MONE >= 10))
    {
       
        MONE10 = (MONE / 10);
        MONE = MONE - (MONE10 * 10);
    }

    if ((MONE >= 5))
    {
        
        MONE5 = (MONE / 5);
        MONE = MONE - (MONE5 * 5);
    }

    Console.WriteLine($"ESTOS SON TUS monedas");
    Console.WriteLine($"MONEDA DE 50: {MONE50}");
    Console.WriteLine($"MONEDA DE 25: {MONE25}");
    Console.WriteLine($"MONEDA DE 10: {MONE10}");
    Console.WriteLine($"MONEDA DE 5: {MONE5}");
    Console.WriteLine($"MONEDA DE 1: {MONE}");

}
desglose();

static void ConverciónDolarQuetzal()
{
    int G1, C200, C100, C50, C20, C10, C5, sob;
    C200 = C100 = C50 = C20 = C10 = C5 = 0;

    float G2, c50, c25, c10, c5, c1, CAN;
    c50 = c25 = c10 = c5 = c1 = 0.0f;

    Console.WriteLine("Ingrese la cantidad en dolares: $");
    CAN = Convert.ToSingle(Console.ReadLine());
    CAN = (float)(CAN * 7.66);

    Console.WriteLine($"Dolares a : Q{CAN}");
    Console.WriteLine($"\nEl desglose en Q es:");

    if ((CAN >= 200))
    {
        C200 = (int)(CAN / 200);
        CAN = CAN - (C100 * 200);
    }

    if ((CAN >= 100))
    {
        C100 = (int)(CAN / 100);
        CAN = CAN - (C100 * 100);
    }
    if ((CAN >= 50))
    {
        C50 = (int)(CAN / 50);
        CAN = CAN - (C50 * 50);
    }
    if ((CAN >= 20))
    {
        C20 = (int)(CAN / 20);
        CAN = CAN - (C20 * 20);
    }
    if ((CAN >= 10))
    {
        C10 = (int)(CAN / 10);
        CAN = CAN - (C10 * 10);
    }
    if ((CAN >= 5))
    {
        C5 = (int)(CAN / 5);
        CAN = CAN - (C5 * 5);
    }

    G1 = (int)CAN;
    sob = (int)CAN;
    G2 = (float)sob;
    CAN = (float)(-sob + CAN);
    Console.WriteLine($"BILLETES DE Q200: {C200}");
    Console.WriteLine($"BILLETES DE Q100: {C100}");
    Console.WriteLine($"BILLETES DE Q50: {C50}");
    Console.WriteLine($"BILLETES DE Q20: {C20}");
    Console.WriteLine($"BILLETES DE Q10: {C10}");
    Console.WriteLine($"BILLETES DE Q5: {C5}");
    Console.WriteLine($"BILLETES DE Q1: {G1}");


}

ConverciónDolarQuetzal();
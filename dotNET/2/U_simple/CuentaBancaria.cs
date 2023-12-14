/** * Alejandro Ayala Castro * ES1822035905 * DS-DPRN2-2302-B2-002
 *  * Complemento a la clase CuentaBancaria de CARLOS ALBERTO NUÑEZ PEREZ
 * se omite parte del codigo con el fin de mostrar la propuesta de complemento al codigo.
 *  * */

 public class CuentaBancaria
 {
    private string titular;
    private double saldo;
    public CuentaBancaria(string titular, double saldo){    }
    public void Retirar(double cantidad){    }
    public void Depositar(double cantidad){    }
    public double ConsultarSaldo(){        return saldo;    }

    public static double verificarCantidad(string value){
        double number=0;
        if (Double.TryParse(value, out number)){
            Console.WriteLine("Converti '{0}' --> {1}", value, number);
            return number;
        }else{
            throw new FormatException("NO es un valor numerico '{0}'.", value);
        }
    }
 }

/** --- */
public class Program{
    public static void Main(){
        try
        {
            string input = Console.ReadLine();
            double cantidad = verificarCantidad(input);
            // ... tu codigo
        }
        catch (System.Exception ex)
        {
            // tu codigo
        }
    }
}
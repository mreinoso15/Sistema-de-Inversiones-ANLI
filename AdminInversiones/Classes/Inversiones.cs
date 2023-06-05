using System;


namespace AdminInversiones
{
    public class HistorialTasas
    {
        public string Tasa { get;set; }
        public float Cantidad { get;set; }
        public string Fecha { get;set; }
    }
    public class Inversiones
    {
        public int NoSocio { get; set; }
        public int solicitudInv { get; set; }
        public string Socio { get; set; }
        public DateTime Fecha { get; set; }
        public double Cantidad { get; set; }    
        public double Tasa { get; set; }

    }

    public class Depositos
    {
        public string Nombre { get; set; }
        public int IdUsuario { get; set; }
        public int IdDeposito { get; set; }
        public double Cantidad { get; set; }
        public string FechaAprob { get; set; }
        public double Tasa { get; set; }
    }

    public class DepositosCalculados
    {
        public string Nombre { get; set; }
        public int IdUsuario { get; set; }
        public int IdDeposito { get; set; }
        public double Cantidad { get; set; }
        public string FechaAprob { get; set; }
        public double Tasa { get; set; }
    }
    public class Retiros
    {
        public string Nombre { get; set; }
        public int IdUsuario { get; set; }
        public int IdRetiro { get; set; }
        public double Cantidad { get; set; }
        public string FechaAprob { get; set; }
    }

    public class Impuestos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public double Cantidad { get; set; }

        public override string ToString()
        {
            return Id+" "+Nombre+" "+Fecha.ToString("dd-MM-yyyy")+" "+Cantidad;
        }
    }

    public class Usuario
    {
       public int ID { get; set; }
       public string Nombre { get; set; }
       public string Fecha_Registro { get; set; }
       public float Cantidad_Ahorro { get; set; }
       public string Estatus { get; set; }

        public override string ToString()
        {
            return ID+" "+Nombre+" "+Fecha_Registro+" "+Cantidad_Ahorro+" "+Estatus;
        }
    }

}

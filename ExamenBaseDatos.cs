namespace ProyectoPrototipo;

public class ExamenBaseDatos : Examen
{
    private string motorDB;
    private bool incluyeSQL;

    public ExamenBaseDatos(string docente, string salon, string grupo, string semestre,
                            string motorDB, bool incluyeSQL)
        : base("BD-303", "Base de Datos", docente, salon, grupo,
               20, 90, semestre, "Teorico-Practico")
    {
        this.motorDB   = motorDB;
        this.incluyeSQL = incluyeSQL;
    }

    private ExamenBaseDatos(ExamenBaseDatos otro) : base(otro)
    {
        motorDB    = otro.motorDB;
        incluyeSQL = otro.incluyeSQL;
    }

    public override object Clone() => new ExamenBaseDatos(this);

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Motor DB      : {motorDB}");
        Console.WriteLine($"Incluye SQL   : {(incluyeSQL ? "Si" : "No")}");
        Console.WriteLine("========================================");
    }
}
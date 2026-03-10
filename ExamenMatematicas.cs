namespace ProyectoPrototipo;

public class ExamenMatematicas : Examen
{
    private string tematica;
    private bool permitidaCalculadora;

    public ExamenMatematicas(string docente, string salon, string grupo, string semestre,
                              string tematica, bool permitidaCalculadora)
        : base("MAT-101", "Matematicas Discretas", docente, salon, grupo,
               30, 90, semestre, "Parcial")
    {
        this.tematica             = tematica;
        this.permitidaCalculadora = permitidaCalculadora;
    }

    private ExamenMatematicas(ExamenMatematicas otro) : base(otro)
    {
        tematica             = otro.tematica;
        permitidaCalculadora = otro.permitidaCalculadora;
    }

    public override object Clone() => new ExamenMatematicas(this);

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Tematica      : {tematica}");
        Console.WriteLine($"Calculadora   : {(permitidaCalculadora ? "Si" : "No")}");
        Console.WriteLine("========================================");
    }
}
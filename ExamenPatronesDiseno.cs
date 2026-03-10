namespace ProyectoPrototipo;

public class ExamenPatronesDiseno : Examen
{
    private string[] patronesEvaluados;
    private bool esProyecto;

    public ExamenPatronesDiseno(string docente, string salon, string grupo, string semestre,
                                 string[] patronesEvaluados, bool esProyecto)
        : base("POO-305", "Patrones de Diseno", docente, salon, grupo,
               20, 120, semestre, "Proyecto")
    {
        this.patronesEvaluados = patronesEvaluados;
        this.esProyecto        = esProyecto;
    }

    private ExamenPatronesDiseno(ExamenPatronesDiseno otro) : base(otro)
    {
        patronesEvaluados = (string[])otro.patronesEvaluados.Clone();
        esProyecto        = otro.esProyecto;
    }

    public override object Clone() => new ExamenPatronesDiseno(this);

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Patrones      : {string.Join(", ", patronesEvaluados)}");
        Console.WriteLine($"Es Proyecto   : {(esProyecto ? "Si" : "No")}");
        Console.WriteLine("========================================");
    }
}
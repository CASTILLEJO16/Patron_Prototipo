namespace ProyectoPrototipo;

public class ExamenFisica : Examen
{
    private string laboratorio;
    private bool requiereFormulario;

    public ExamenFisica(string docente, string salon, string grupo, string semestre,
                         string laboratorio, bool requiereFormulario)
        : base("FIS-201", "Fisica General", docente, salon, grupo,
               25, 100, semestre, "Ordinario")
    {
        this.laboratorio       = laboratorio;
        this.requiereFormulario = requiereFormulario;
    }

    private ExamenFisica(ExamenFisica otro) : base(otro)
    {
        laboratorio        = otro.laboratorio;
        requiereFormulario = otro.requiereFormulario;
    }

    public override object Clone() => new ExamenFisica(this);

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Laboratorio   : {laboratorio}");
        Console.WriteLine($"Formulario    : {(requiereFormulario ? "Si" : "No")}");
        Console.WriteLine("========================================");
    }
}
namespace ProyectoPrototipo;

public class ExamenRedes : Examen
{
    private string protocolosEvaluados;
    private bool usaSimulador;

    public ExamenRedes(string docente, string salon, string grupo, string semestre,
                        string protocolosEvaluados, bool usaSimulador)
        : base("RED-401", "Redes de Computadoras", docente, salon, grupo,
               25, 100, semestre, "Mixto")
    {
        this.protocolosEvaluados = protocolosEvaluados;
        this.usaSimulador        = usaSimulador;
    }

    private ExamenRedes(ExamenRedes otro) : base(otro)
    {
        protocolosEvaluados = otro.protocolosEvaluados;
        usaSimulador        = otro.usaSimulador;
    }

    public override object Clone() => new ExamenRedes(this);

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Protocolos    : {protocolosEvaluados}");
        Console.WriteLine($"Simulador     : {(usaSimulador ? "Si" : "No")}");
        Console.WriteLine("========================================");
    }
}
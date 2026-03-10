namespace ProyectoPrototipo;

public abstract class Examen : ICloneable
{
    protected string claveMateria;
    protected string nombreAsignatura;
    protected string docente;
    protected string salon;
    protected string grupo;
    protected int numeroPreguntas;
    protected int duracionMinutos;
    protected string semestre;
    protected string tipoExamen;

    protected Examen(string claveMateria, string nombreAsignatura, string docente,
                     string salon, string grupo, int numeroPreguntas,
                     int duracionMinutos, string semestre, string tipoExamen)
    {
        this.claveMateria     = claveMateria;
        this.nombreAsignatura = nombreAsignatura;
        this.docente          = docente;
        this.salon            = salon;
        this.grupo            = grupo;
        this.numeroPreguntas  = numeroPreguntas;
        this.duracionMinutos  = duracionMinutos;
        this.semestre         = semestre;
        this.tipoExamen       = tipoExamen;
    }

    // Constructor de copia protegido para clonacion
    protected Examen(Examen otro)
    {
        claveMateria     = otro.claveMateria;
        nombreAsignatura = otro.nombreAsignatura;
        docente          = otro.docente;
        salon            = otro.salon;
        grupo            = otro.grupo;
        numeroPreguntas  = otro.numeroPreguntas;
        duracionMinutos  = otro.duracionMinutos;
        semestre         = otro.semestre;
        tipoExamen       = otro.tipoExamen;
    }

    public abstract object Clone();

    public string GetClaveMateria()     => claveMateria;
    public string GetNombreAsignatura() => nombreAsignatura;
    public string GetDocente()          => docente;
    public string GetSalon()            => salon;
    public string GetGrupo()            => grupo;
    public int    GetNumeroPreguntas()  => numeroPreguntas;
    public int    GetDuracionMinutos()  => duracionMinutos;
    public string GetSemestre()         => semestre;
    public string GetTipoExamen()       => tipoExamen;

    public void SetGrupo(string nuevoGrupo)   => grupo = nuevoGrupo;
    public void SetSalon(string nuevoSalon)   => salon = nuevoSalon;
    public void SetDocente(string nuevoDocente) => docente = nuevoDocente;

    public virtual void MostrarInfo()
    {
        Console.WriteLine("========================================");
        Console.WriteLine($"Materia       : {nombreAsignatura}");
        Console.WriteLine($"Clave         : {claveMateria}");
        Console.WriteLine($"Docente       : {docente}");
        Console.WriteLine($"Salon         : {salon}");
        Console.WriteLine($"Grupo         : {grupo}");
        Console.WriteLine($"Semestre      : {semestre}");
        Console.WriteLine($"Tipo Examen   : {tipoExamen}");
        Console.WriteLine($"Preguntas     : {numeroPreguntas}");
        Console.WriteLine($"Duracion (min): {duracionMinutos}");
    }
}
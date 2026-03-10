using ProyectoPrototipo;

Console.WriteLine("========================================");
Console.WriteLine("   PATRON PROTOTIPO - SISTEMA EXAMENES  ");
Console.WriteLine("========================================\n");

// --- Crear prototipos originales ---
var examenMat = new ExamenMatematicas(
    "Dr. Lopez", "A-101", "GDS-1A", "2024-1",
    "Logica Proposicional", false);

var examenFis = new ExamenFisica(
    "Ing. Garcia", "B-205", "GDS-2A", "2024-1",
    "Lab Central", true);

var examenPatrones = new ExamenPatronesDiseno(
    "Ing. Martinez", "C-301", "GDS-4A", "2024-1",
    new[] { "Prototipo", "Singleton", "Factory" }, true);

var examenProg = new ExamenProgramacion(
    "Dr. Lopez", "A-102", "GDS-3A", "2024-1",
    "C#", false);

var examenBD = new ExamenBaseDatos(
    "Lic. Torres", "D-401", "GDS-3B", "2024-1",
    "MySQL", true);

var examenRedes = new ExamenRedes(
    "Ing. Ramirez", "E-501", "GDS-4B", "2024-1",
    "TCP/IP, UDP, HTTP", true);

var examenCalculo = new ExamenCalculo(
    "Dra. Sanchez", "A-103", "GDS-1B", "2024-1",
    "Limites y Derivadas", 5);

var examenAlg = new ExamenAlgoritmos(
    "Ing. Martinez", "C-302", "GDS-2B", "2024-1",
    "Arboles y Grafos", true);

// --- Mostrar prototipos originales ---
Console.WriteLine("\n--- EXAMENES ORIGINALES ---\n");
examenMat.MostrarInfo();
examenFis.MostrarInfo();
examenPatrones.MostrarInfo();
examenProg.MostrarInfo();
examenBD.MostrarInfo();
examenRedes.MostrarInfo();
examenCalculo.MostrarInfo();
examenAlg.MostrarInfo();

// --- Clonar y modificar para distintos grupos ---
Console.WriteLine("\n--- CLONES PARA OTROS GRUPOS (mismo docente) ---\n");

var examenMatGrupo2 = (ExamenMatematicas)examenMat.Clone();
examenMatGrupo2.SetGrupo("GDS-1B");
examenMatGrupo2.SetSalon("A-102");
examenMatGrupo2.MostrarInfo();

var examenPatronesGrupo2 = (ExamenPatronesDiseno)examenPatrones.Clone();
examenPatronesGrupo2.SetGrupo("GDS-4B");
examenPatronesGrupo2.SetSalon("C-303");
examenPatronesGrupo2.MostrarInfo();

var examenAlgGrupo2 = (ExamenAlgoritmos)examenAlg.Clone();
examenAlgGrupo2.SetGrupo("GDS-2C");
examenAlgGrupo2.SetSalon("C-304");
examenAlgGrupo2.MostrarInfo();

// --- Clonar y cambiar docente (misma materia, distinto profesor) ---
Console.WriteLine("\n--- CLONES CON OTRO DOCENTE (misma materia) ---\n");

var examenPatronesOtroDoc = (ExamenPatronesDiseno)examenPatrones.Clone();
examenPatronesOtroDoc.SetGrupo("GDS-4C");
examenPatronesOtroDoc.SetSalon("C-305");
examenPatronesOtroDoc.SetDocente("Dr. Hernandez");
examenPatronesOtroDoc.MostrarInfo();

var examenBDOtroDoc = (ExamenBaseDatos)examenBD.Clone();
examenBDOtroDoc.SetGrupo("GDS-3C");
examenBDOtroDoc.SetSalon("D-402");
examenBDOtroDoc.SetDocente("Ing. Flores");
examenBDOtroDoc.MostrarInfo();

Console.WriteLine("\n--- FIN DEL PROGRAMA ---");
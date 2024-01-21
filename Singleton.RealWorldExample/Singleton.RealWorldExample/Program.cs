using Singleton.RealWorldExample;

EventLogger logger = EventLogger.GetInstance();
EventLogger logger2 = EventLogger.GetInstance();
EventLogger logger3 = EventLogger.GetInstance();

logger.LogEvent("Comenzando el curso app.");
logger.LogEvent("Ejecutando el log de tarea 1.");
logger.LogEvent("EL último logh.");
logger.LogEvent("Se finin el proceso.");


logger2.LogEvent("when curso.");
logger2.LogEvent("ponele weno.");
logger3.LogEvent("se puda.");
logger3.LogEvent("Dios mediante.");


//logger.DisplayLogs();
//logger2.DisplayLogs();
logger3.DisplayLogs();

using Builder.Example1;

// se crea el "robotBuilder" con la interfaz IRobotBuilder
IRobotBuilder robotBuilder = new RobotBuilder();

// se crea el director, que es el que va a decidir como se construye el robot "robotDirector" y se le pasa por parametros el builder "robotBuilder" 
RobotDirector robotDirector = new RobotDirector(robotBuilder);

// ahora se le dice al director que construya el robot
robotDirector.ConstructRobot();

// una vez construido el robot, se le pide que lo devuelva en la variable "robot"
Robot robot = robotBuilder.GetRobot();

// se muestra la criatura
robot.DisplayRobotInfo();
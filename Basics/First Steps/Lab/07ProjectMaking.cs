string architectName = Console.ReadLine();
int numberOfprojects = int.Parse(Console.ReadLine());

// Because 3 hours per project
int neededTime = numberOfprojects * 3;

//•	"The architect {името на архитекта} will need {необходими часове} hours to complete {брой на проектите} project/s."
string info = $"The architect {architectName} will need {neededTime} hours to complete {numberOfprojects} project/s.";
Console.WriteLine(info);

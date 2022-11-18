
using SingletonDesignPatternThreadSafe;

Parallel.Invoke(
    ()=>PrintStudentDetails(),
    ()=>PrintTeacherDetails());

 static void PrintTeacherDetails()
{
    Singleton fromTeacher = Singleton.GetInstance;
    fromTeacher.PrintDetails("From Teacher");
}

static void PrintStudentDetails()
{
    Singleton fromStudent = Singleton.GetInstance;
    fromStudent.PrintDetails("From Student");
}

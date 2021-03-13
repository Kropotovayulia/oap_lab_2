<table style="width: 100%;">
  <tr>
    <td style="text-align: center; border: none;">
    Министерство образования и науки РФ<br>
Государственное бюджетное профессиональное образовательное учреждение Республики Марий Эл<br>
Йошкар-Олинский технологический колледж
</td>
  </tr>
  <tr>
    <td style="text-align: center; border: none; height: 15em;">
    <h2 style="font-size:3em;">Отчет</h2>
      <h3>по лабораторной работе<br><br> по дисциплине "Основы алгоритмизации и программирования"<br><br> Тема:<b>"Многопоточность."<b> </h3></td>
  </tr>
  <tr>
    <br><br><td style="text-align: right; border: none; height: 20em;">
      Разработал:<br/>
      Кропотова Юлия<br>
      Группа: И-21<br>
      Преподаватель:<br>
      Колесников Евгений Иванович
    </td>
  </tr>
  <tr>
    <td style="text-align: center; border: none; height: 5em;">
    г.Йошкар-Ола, 2021</td>
  </tr>
</table>

<div style="page-break-after: always;"></div>

# Цели и задачи:
 1.  Научится определять запуск 3 разными способами
 2. Узнать о асинхронном программировании. Асинхронные методы, async и await.
 3. Методы
 4. Научится определять асинхронную операцию



# Краткий материал.

1. Для определения и запуска задачи можно использовать различные способы. Первый способ создание объекта ```Task``` и вызов у него метода ```Start: ``` 

    ```
    Task task = new Task(() => Console.WriteLine("Hello Task!"));
task.Start();
    ```

   Второй способ заключается в использовании статического метода ```Task.Factory.StartNew().``` Этот метод также в качестве параметра принимает делегат Action, который указывает, какое действие будет выполняться.

    ```
    Task task = Task.Factory.StartNew(() => Console.WriteLine("Hello Task!"));
    ```

   Третий способ определения и запуска задач представляет использование статического метода ```Task.Run():```
    ```
    Task task = Task.Run(() => Console.WriteLine("Hello Task!"));
    ```

2. Слово async, которое указывается в определении метода, не делает автоматически метод асинхронным. Оно лишь указывает, что данный метод может содержать одно или несколько выражений await.

    ```
    // определение асинхронного метода
        static async void FactorialAsync()
        {
            Console.WriteLine("Начало метода FactorialAsync"); // выполняется синхронно
            await Task.Run(()=>Factorial());                // выполняется асинхронно
            Console.WriteLine("Конец метода FactorialAsync");
        }
 
        static void Main(string[] args)
        {
            FactorialAsync();   // вызов асинхронного метода
 
            Console.WriteLine("Введите число: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Квадрат числа равен {n * n}");
             
            Console.Read();
    ```
3. Асинхронный метод ReadWriteAsync() выполняет запись в файл некоторой строки и затем считывает записанный файл. Подобные операции могут занимать продолжительное время, особенно при больших объемах данных, поэтому такие операции лучше делать асинхронными.

   ```
    await writer.WriteLineAsync(s);  // асинхронная запись в файл

    ```
4. Определение асинхронной операции
   
    Как выше уже было сказано, фреймворк .NET имеет много встроенных методов, которые представляют асинхронную операцию. Они заканчиваются на суффикс Async. И перед вызывами подобных методов мы можем указывать оператор ```await.```
    

    ```
    StreamWriter writer = new StreamWriter("hello.txt", false);
    await writer.WriteLineAsync("Hello");  // асинхронная запись в файл
    ```

# Вывод
В данной лабораторной работе мы научились работать с асинхронными методами решений задач и научились их определять
using System;

namespace если
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }<!DOCTYPE html>
<html>
<head>
<script type = 'text/javascript' >
function fun1()
        {
            alert('Вас привествует учебный центр');
        }
        function fun2()
        {
            let ok = confirm('Текст вопроса');
            alert(ok);
            let ok = confirm('Хотите стать Web-дизайнером?');

            if (ok)
            {
                alert('Учите стили CSS и JavaScript!');
            }
            else
            {
                alert('Упускаете время!');
            }
        }

        function fun3()
        {
            x = prompt('Введите имя:', 'Имя');
            document.write('Добро пожаловать на наши курсы, ' + x);
        }


</script>
</head>
<body>
<input type = 'button' value='Приветствие' onclick='fun1()' />
<input type = 'button' value='Хотите стать Web-дизайнером?' onclick='fun2()' />
<input type = 'button' value='Введите имя' onclick='fun3()' />
</body>
</html>
    }
}

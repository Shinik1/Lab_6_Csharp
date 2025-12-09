ЗАДАНИЕ 1.1: КОТ
Цель: Создать сущность Кота с возможностью мяукать.

Класс Cat
Поля:
public string name - имя кота

Конструктор:
Cat(string name) - создает кота с указанным именем

Методы:
ToString() - возвращает строку в формате "кот: {имя}"
Meow() - выводит на экран "{имя}: мяу!"
Meow(int count) - выводит "{имя}: мяу-...-мяу!" (count раз)

<img width="251" height="117" alt="image" src="https://github.com/user-attachments/assets/7af7c23d-5537-456d-9a1a-6be23e15f76d" />

ЗАДАНИЕ 1.2: ИНТЕРФЕЙС МЯУКАНЬЕ
Цель: Создать метод, работающий с любыми мяукающими объектами.

Интерфейс IMeowable

Методы:
void Meow() - метод мяуканья

Классы, реализующие интерфейс:
Cat - уже реализует Meow()

SadCat - новый класс для демонстрации

Метод в Program:
MakeAllMeow(List<IMeowable> list) - вызывает Meow() у всех объектов в списке

<img width="305" height="289" alt="image" src="https://github.com/user-attachments/assets/f16ae546-84a5-46c9-b1c9-ed00ad3096c4" />

ЗАДАНИЕ 1.3: КОЛИЧЕСТВО МЯУКАНИЙ
Цель: Подсчитать количество мяуканий без изменения класса Cat.

Класс CatCounter (шаблон Декоратор)

Поля:
private Cat _cat - ссылка на кота
private int _meowCount - счетчик мяуканий

Свойства:
MeowCount - количество мяуканий (только чтение)
CounterCat - кот (только чтение)

Конструктор:
CatCounter(Cat cat) - создает счетчик для указанного кота

Методы:
Meow() - вызывает мяуканье у кота и увеличивает счетчик
ToString() - возвращает информацию о счетчике
<img width="557" height="257" alt="image" src="https://github.com/user-attachments/assets/afb2a295-bbba-4119-80b2-1196177b828d" />



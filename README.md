ЗАДАНИЕ 1: КОТ
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


Задание 2: Дроби

Класс Fraction
Поля:
private int numerator - числитель
private int denominator - знаменатель
private double? cachedValue - кэш вещественного значения

Конструктор:
Fraction(int num, int den) - создает дробь с проверкой знаменателя

Методы:
Sum(Fraction other) - сложение дробей
Minus(Fraction other) - вычитание дробей
Minus(int value) - вычитание целого числа
Mul(Fraction other) - умножение дробей
Div(Fraction other) - деление дробей
ToString() - возвращает "числитель/знаменатель"
Equals(object obj) - сравнение дробей
Clone() - клонирование (ICloneable)
ToDouble() - вещественное значение (с кэшированием)
SetNumerator(int value) - установка числителя
SetDenominator(int value) - установка знаменателя

<img width="391" height="450" alt="image" src="https://github.com/user-attachments/assets/80fbe4d5-5118-4567-b6c7-c6ac5e1f87ae" />
<img width="487" height="190" alt="image" src="https://github.com/user-attachments/assets/11ff3558-3005-473e-a78d-2a991e892518" />

Задание 2.2
Переопределен метод Equals() для сравнения по состоянию.

<img width="321" height="72" alt="image" src="https://github.com/user-attachments/assets/d8a47203-cb6a-4d0c-9c36-5b2298750b62" />

Задание 2.3
Метод Clone() создает новый объект Fraction с теми же значениями полей

<img width="295" height="73" alt="image" src="https://github.com/user-attachments/assets/e29ddc99-db04-424b-b49e-3a82dd315b90" />


Задание 2.4
Интерфейс IFractionActions:

double ToDouble() - получение вещественного значения
void SetNumerator(int value) - установка числителя
void SetDenominator(int value) - установка знаменателя

<img width="470" height="213" alt="image" src="https://github.com/user-attachments/assets/6eea347c-65d4-4c97-8a7b-72e0c4d6f7be" />

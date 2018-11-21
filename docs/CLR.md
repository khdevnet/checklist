# CLR
1. Compile code in CLR, JitCompilation flow
2. FCL Framework Class Library contains assemblies with different types which help with application creation (ASP.NET,Console, Windows Forms)
3. CTS (Common Type System), которая описывает способ определения и поведение типов. Позволяет коду, написанному на одном языке программирования, взаимодействовать с кодом, написанным на другом CLR языке. CTS также задает правила видимости типов и доступа к членам типа.
CLS
4. CLS (Common Language Specification); в ней перечислен минимальный набор возможностей, которые должны поддерживаться компилятором для генерирования типов, совместимых с другими компонентами, написанными на других CLS-совместимых языках на базе CLR.CLS определяет правила, которым должны соответствовать типы и методы с внешней видимостью, для того чтобы они могли использоваться в любом CLS-совместимом языке программирования
5. COM specifies an object model and programming requirements that enable COM objects (also called COM components, or sometimes simply objects) to interact with other objects. These objects can be within a single process, in other processes, and can even be on remote computers. They can be written in different languages, and they may be structurally quite dissimilar, which is why COM is referred to as a binary standard; a standard that applies after a program has been translated to binary machine code.
6. (Рихтер стр. 133) Как разные компоненты взаимодействуют во время выполнения
7. [Статические классы и члены статических](https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members)
8. (Рихтер стр. 150) Ссылочные/значимые типы
 Если тип называют классом (class), речь идет о ссылочном типе.
 Если тип называют структурой (struct) или перечислениями (enumeration), речь идет о значимом типе.
 Все структуры являются прямыми потомками абстрактного типа System.ValueType, который, в свою очередь, является производным от типа System.Object. CLR значимый тип является изолированным, то есть он не может служить базовым типом для какого-либо другого ссылочного
или значимого типа, может наследоваться от интерфейса.
Значимый тип является неявно запечатанным.
Значимый тип копируется по значению, ссылочный тип по ссылке
Нельзя наследоваться от значимого типа.
Значимый тип можно разширять интерфейсом.
9. ***Equals и GetHashCode***, — состоит в том, что реализация типов System.Collections.
Hashtable, System.Collections.Generic.Dictionary и любых других коллекций
требует, чтобы два равных объекта имели одинаковые значения хеш-кодов. По-
этому, переопределяя Equals, нужно переопределить GetHashCode и обеспечить
соответствие алгоритма
10. [Events vs Delegate](https://dzone.com/articles/event-vs-delegate)

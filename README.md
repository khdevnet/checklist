
# Checklist
## .NET
### Covariance and Contravariance in Generics
* **Covariance** Enables you to use a more derived type than originally specified. You can assign an instance of ```IEnumerable<Derived>``` to a variable of type ```IEnumerable<Base>```.

* **Contravariance** Enables you to use a more generic (less derived) type than originally specified. You can assign an instance of ```Action<Base>``` to a variable of type ```Action<Derived>```.

* **Invariance** Means that you can use only the type originally specified; so an invariant generic type parameter is neither covariant nor contravariant. You cannot assign an instance of ```List<Base>``` to a variable of type ```List<Derived>``` or vice versa.
  
### GetHashcode, Equals
* [Generate Equals and GetHashCode](https://docs.microsoft.com/en-us/visualstudio/ide/reference/generate-equals-gethashcode-methods?view=vs-2019)
* [GetHashCode and Equals override in C#](https://www.codementor.io/@dhananjaykumar/gethashcode-and-equals-override-in-c-y7vugbpie)
### IEquatable, IComparable
### Delegate vs events
* [Delegate vs events](https://dzone.com/articles/event-vs-delegate)
* [Delegate vs events](https://docs.microsoft.com/en-us/dotnet/csharp/distinguish-delegates-events)
### Domains
* [application-domains](https://docs.microsoft.com/en-us/dotnet/framework/app-domains/application-domains)
###  Exceptions handling
###  Garbage Collector
* [fundamentals](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/fundamentals)
#### **GC roots** are not objects in themselves but are instead references to objects. Any object referenced by a GC root will automatically survive the next garbage collection. There are four main kinds of root in .NET:
* A **local variable** in a method that is currently running is considered to be a GC root. The objects referenced by these variables can always be accessed immediately by the method they are declared in, and so they must be kept around. The lifetime of these roots can depend on the way the program was built. In debug builds, a local variable lasts for as long as the method is on the stack. In release builds, the JIT is able to look at the program structure to work out the last point within the execution that a variable can be used by the method and will discard it when it is no longer required. This strategy isn’t always used and can be turned off, for example, by running the program in a debugger.

* **Static variables** are also always considered GC roots. The objects they reference can be accessed at any time by the class that declared them (or the rest of the program if they are public), so .NET will always keep them around. Variables declared as ‘thread static’ will only last for as long as that thread is running.

* If a **managed object** is passed to an unmanaged COM+ library through interop, then it will also become a GC root with a reference count. This is because COM+ doesn’t do garbage collection: It uses, instead, a reference counting system; once the COM+ library finishes with the object by setting the reference count to 0 it ceases to be a GC root and can be collected again.

* If an **object has a finalizer**, it is not immediately removed when the garbage collector decides it is no longer ‘live’. Instead, it becomes a special kind of root until .NET has called the finalizer method. This means that these objects usually require more than one garbage collection to be removed from memory, as they will survive the first time they are found to be unused.

#### Garbage collection occurs when one of the following conditions is true
* The system has low physical memory. This is detected by either the low memory notification from the OS or low memory indicated by the host.
* The memory that is used by allocated objects on the managed heap surpasses an acceptable threshold. This threshold is continuously adjusted as the process runs.
* The GC.Collect method is called. In almost all cases, you do not have to call this method, because the garbage collector runs continuously. This method is primarily used for unique situations and testing.

###  Finialize, Dispose
###  Collections
###  Data types
###  [asp.net Core Request flow](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-6.0)
###  OWIN

## Other
###  Middleware, ETL, HTTP 2.
###  OOAD, OOD, SOLID.
###  DRY, LoD, SoC, KISS, Low coupoling and high cohesion
###  CQRS, Event Sourcing.
###  Mutex, Semaphore, Critical Section.
### [Databases](https://github.com/khdevnet/checklist/tree/master/databases)

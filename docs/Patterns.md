# Patterns

**MVC (Model-View-Controller)**   
The MVC model defines web applications with 3 logic layers:
* The business layer (Model logic)
* The display layer (View logic)
* The input control (Controller logic)

[Resource](https://www.c-sharpcorner.com/UploadFile/8ef97c/most-asked-Asp-Net-mvc-interview-questions-and-answers/)

**MVVM (Model-View-ViewModel)**
* View - The view is responsible for defining the structure, layout, and appearance of what the user sees on the screen. 
A view gets data from its view model through bindings, or invoking methods on the view model. At run time, the view changes when UI    controls respond to view model properties raising change notification events.

* Model - The model in MVVM is an implementation of the application's domain model that includes a data model along with business and validation logic. Examples of model objects include repositories, business objects, data transfer objects (DTOs), Plain Old CLR Objects (POCOs), and generated entity and proxy objects.

* View Model - The view model acts as an intermediary between the view and the model, and is responsible for handling the view logic. Typically, the view model interacts with the model by invoking methods in the model classes. The view model then provides data from the model in a form that the view can easily use. The view model retrieves data from the model and then makes the data available to the view, and may reformat the data in some way that makes it simpler for the view to handle. The view model also provides implementations of commands that a user of the application initiates in the view. For example, when a user clicks a button in the UI, that action can trigger a command in the view model. The view model may also be responsible for defining logical state changes that affect some aspect of the display in the view, such as an indication that some operation is pending. [Resource](http://wpbest.net/mvvm-model-view-viewmodel-pattern-with-xamarin-forms)
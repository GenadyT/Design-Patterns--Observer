## Observer Design Patterns

This .Net C# project demonstrates "Observer" design pattern and is inspired by the book - 
	-------------------------------------------------------------------
	Freeman, Eric; Robson, Elisabeth; Bates, Bert; Sierra, Kathy. 
	Head First Design Patterns: A Brain-Friendly Guide. O'Reilly Media.
	-------------------------------------------------------------------

### Pattern Definition

The Observer Pattern defines a one-to-many relationship between a set of objects. 
When the state of one object changes, all of its dependents are notified.	

### The Project Main Code Units

The pattern Subject class is the project ForecastNotifier class
The pattern Observer class is the project FanOfTheSea class
The pattern DisplayElement class is the project IDisplayElement interface
The pattern Observers are SunBather, Surfer, and Swimmer classes

### The Project Construct Idea Algorithm

1.. The user clicks the "Update JSON forecast and view results..." button 
	and the JSON data file is modified.
2.. There is a subproject "FileManager" and the subproject manages the File Watcher C# transaction.
	Therefore, when the contents of the data file "Miami_coasts_forecast.json" changes, 
	an observetion transaction is triggered.
3.. The "Subject" ForecastNotifier class continues the observetion transaction 
	and notify the observers: 	SunBather, Surfer, and Swimmer objects.
4.. These observers change their statuses according to the json data.

### Additional Information

The UI images taken from the sources:
-------------------------------------
<a href=\"https://www.flaticon.com/free-icons/surfing\" title=\"surfing icons\">Surfing icons created by Leremy - Flaticon</a>
<a href=\"https://www.flaticon.com/free-icons/swimmer\" title=\"swimmer icons\">Swimmer icons created by Circlon Tech - Flaticon</a>
<a href=\"https://www.flaticon.com/free-icons/sunbathing\" title=\"sunbathing icons\">Sunbathing icons created by Prosymbols Premium - Flaticon</a>
<a href=\"https://www.flaticon.com/free-icons/satisfied\" title=\"satisfied icons\">Satisfied icons created by Sebastian Belalcazar - Flaticon</a>
<a href=\"https://www.flaticon.com/free-icons/sad\" title=\"sad icons\">Sad icons created by Vectors Market - Flaticon</a>


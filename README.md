### Assert Methodları

```csharp
Assert.Contains("Fatih", "Fatih Çakıroğlu");
Assert.DoesNotContain("emre", "Fatih Çakıroğlu");

var names = new List<string>() { "Fatih", "Emre", "Hasan" };
Assert.Contains(names, x => x == "Fatih");
Assert.DoesNotContain(names, x => x == "Berkecan");

Assert.True(5 > 2);
Assert.False(2 > 5);
Assert.True("".GetType() == typeof(string));

var regEx = "^dog"; // Starts with dog

Assert.Matches(regEx, "dog fatih");
Assert.DoesNotMatch(regEx, "underdog");

Assert.StartsWith("bugs", "bugs bunny");
Assert.EndsWith("duck", "duffy duck");

var bosDizi = new int[] { };
Assert.Empty(bosDizi);

var rapciler = new List<string>() { "Sagopa Kajmer", "Ceza", "Killa Hakan", "Ezhel" };
Assert.NotEmpty(rapciler);

Assert.InRange(10, 2, 20);
Assert.NotInRange(100, 2, 20);

Assert.Single(new List<string>() { "Fatih" });
Assert.Single(new List<string>() { "Fatih", "Hasan" }); // false

Assert.Single<string>(new List<string>() { "Fatih" });

Assert.IsType<List<string>>(new List<string>() { });
Assert.IsNotType<string>(35);
Assert.IsNotType<int>("Fatih");

Assert.IsAssignableFrom<IEnumerable<string>>(new List<string>() { });
Assert.IsAssignableFrom<object>("Fatih");

            string deger = null;
Assert.Null(deger);
Assert.NotNull("Fatih");

Assert.Equal<int>(55, 55);
Assert.Equal("Fatih", "Fatih");
```

### Test Method İsimlendirme

MethodName_StateUnderTest_ExpectedBehavior

Örnek: add_simpleValues_returnTotalValue

Örnek: IndexReturnsARedirectToIndexHomeWhenIdIsNull

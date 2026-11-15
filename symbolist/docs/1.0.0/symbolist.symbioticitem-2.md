# SymbioticItem&lt;TList, TItem&gt;

Namespace: symbolist

Represents a symbiotic list item

```csharp
public abstract class SymbioticItem<TList, TItem> where TList : SymbioticBaseList<TList, TItem> where TItem : SymbioticItem<TList, TItem>
```

#### Type Parameters

`TList`<br>

`TItem`<br>

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [SymbioticItem&lt;TList, TItem&gt;](https://github.com/blackrookgames/symbolist/tree/main/symbolist/docs/1.0.0/symbolist.symbioticitem-2.md)

## Properties

### **List**

List that the item belongs to

```csharp
public TList List { get; }
```

#### Property Value

TList<br>

### **Index**

Index in the list (or -1 if the item is not part of a list)

```csharp
public int Index { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Constructors

### **SymbioticItem()**

```csharp
protected SymbioticItem()
```

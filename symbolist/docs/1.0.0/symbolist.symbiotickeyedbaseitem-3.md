# SymbioticKeyedBaseItem&lt;TList, TItem, TKey&gt;

Namespace: symbolist

Represents the base behavior for a keyed symbiotic list item

```csharp
public abstract class SymbioticKeyedBaseItem<TList, TItem, TKey> : SymbioticItem`2 where TList : SymbioticKeyedBaseList<TList, TItem, TKey> where TItem : SymbioticKeyedBaseItem<TList, TItem, TKey>
```

#### Type Parameters

`TList`<br>

`TItem`<br>

`TKey`<br>

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → SymbioticItem&lt;TList, TItem&gt; → [SymbioticKeyedBaseItem&lt;TList, TItem, TKey&gt;](https://github.com/blackrookgames/symbolist/tree/main/symbolist/docs/1.0.0/symbolist.symbiotickeyedbaseitem-3.md)<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute)

## Properties

### **Key**

Key

```csharp
public TKey Key { get; }
```

#### Property Value

TKey<br>

### **List**

```csharp
public TList List { get; }
```

#### Property Value

TList<br>

### **Index**

```csharp
public int Index { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Constructors

### **SymbioticKeyedBaseItem()**

```csharp
protected SymbioticKeyedBaseItem()
```

## Methods

### **SetKey(TKey)**

Sets the key

```csharp
protected void SetKey(TKey key)
```

#### Parameters

`key` TKey<br>
Key

#### Exceptions

[InvalidOperationException](https://learn.microsoft.com/en-us/dotnet/api/system.invalidoperationexception)<br>
Item is already part of a list

**Remarks:**

Only unlisted items can have their keys changed<br>
 Items with null keys cannot be added to lists

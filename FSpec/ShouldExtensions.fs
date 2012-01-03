[<System.Runtime.CompilerServices.ExtensionAttribute>]
module public ShouldExtensions

(*
    this module implements a series of extensions on the obj class to allow
    for a usage like RSpec's own, where the "should_" methods can be called on any object
    if more specific (that is, not using obj) usages are discovered to be
    needed in the future, add them in specific files

    at the very least we will need these and more detailed implementations
    for strings and such, maybe collections too, etc.

    should_equal(expected)
    should_not_equal(expected)
    should_be_same_as(expected)
    should_not_be_same_as(expected)
    should_contain(string)
    should_have_same_value(object)
    should_match(expected)              * pending seeing regular expressions in f# 
    should_not_match(expected)          * pending seeing regular expressions in f# 
    should_be_nil()                 
    should_not_be_nil()                 * this and the previous one can't really be called on a null object - must be done differently
    should_be_empty()
    should_not_be_empty()               * empty / not empty should be discovered by iterating all members to see if they are set to default values or not
    should_include(sub)
    should_not_include(sub)
    should_be_true()
    should_be_false()

*)


[<System.Runtime.CompilerServices.ExtensionAttribute>]
let should_equal ( _this : obj, x : obj ) = 
    _this.Equals ( x )

[<System.Runtime.CompilerServices.ExtensionAttribute>]
let should_not_equal ( _this : obj, x : obj ) = 
      not ( _this.Equals ( x ))

[<System.Runtime.CompilerServices.ExtensionAttribute>]
let should_be_same_as ( _this : obj, x : obj ) = 
      _this.Equals ( x )

[<System.Runtime.CompilerServices.ExtensionAttribute>]
let should_not_be_same_as ( _this : obj, x : obj ) = 
      not ( _this.Equals ( x ))

[<System.Runtime.CompilerServices.ExtensionAttribute>]
let should_contain ( _this : obj, x : System.String ) = 
      _this.ToString().Contains ( x );

[<System.Runtime.CompilerServices.ExtensionAttribute>]
let should_have_same_value ( _this : obj, x : System.String ) = 
      _this.ToString().Contains ( x.ToString() );

[<System.Runtime.CompilerServices.ExtensionAttribute>]
let should_be_empty ( _this : obj ) =
    match _this with
     | :? System.String as x -> x.Length = 0
     | :? System.ValueType -> false
     | :? System.Collections.Generic.List<'T> as x -> x.Count = 0
     | :? System.Collections.Generic.LinkedList<'T> as x -> x.Count = 0
     | :? System.Collections.IEnumerable as x -> not ( x.GetEnumerator().MoveNext() )
     | :? System.Collections.Generic.IEnumerable<'T> as x -> not ( x.GetEnumerator().MoveNext() )
     | :? obj -> true;;        // this is last case scenario, as it always holds  


(* ---------------------------------------------------------------------------------------------*)

(* these are not proper extension methods as tehy cannot be called on a null object anyway *)

let should_be_null ( x : obj ) =
    x = null;

let should_not_be_null ( x : obj ) =
    not ( x = null );

(* ---------------------------------------------------------------------------------------------*)

//let IsEmtpy x =
//    x.GetType().GetFields() |> 

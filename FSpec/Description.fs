module public FSpec.Core


type Description = class
    val Message : string

    new ( message ) = 
        { Message = message }


end



(*
    this class must have abstrac methods for setup and teardown
    in case user wants to implement them 
*)

type Context = class

    val Title : string

    new ( title ) =
        { Title = title }

end


type Line = class
    val X1 : float32
    val Y1 : float32
    val X2 : float32
    val Y2 : float32
 
   
    new () as this = {
        X1 = 0.0f;
        Y1 = 0.0f;
        X2 = 0.0f;
        Y2 = 0.0f;
      }
    new (x1, y1, x2, y2) as this =
        { X1 = x1; Y1 = y1;
            X2 = x2; Y2 = y2;}
        then
            printfn "Line constructor: {(%F, %F), (%F, %F)}, Line.Length: %F"
                this.X1 this.Y1 this.X2 this.Y2 this.Length
 
    member x.Length =
        let sqr x = x * x
        sqrt(sqr(x.X1 - x.X2) + sqr(x.Y1 - x.Y2) )
end

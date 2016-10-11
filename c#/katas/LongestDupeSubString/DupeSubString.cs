//=================================================/
//LongestDuplicatedSubstring (eg. banana - ana) -- devendag@amazon.com
//-----------------------------------------------------------------------

public static class DupeSubstring {
         

    public static string Longest(string val){
        var currentContextStr = "";
        // substring starting at 0, 
        val = val.ToLower();
        
       for(var substringLength=val.Length-1; substringLength>0; substringLength--){
    
            for(int index=0; index < val.Length; index++){
            
                if(index + substringLength <= val.Length){
                    currentContextStr = val.Substring(index, substringLength);
                    for(int compareIndex=index+1; compareIndex < val.Length; compareIndex++){
                        if(compareIndex + substringLength <= val.Length){
                            if(currentContextStr.Equals(val.Substring(compareIndex, substringLength))) return currentContextStr;
                        }
                        else{
                           break;     
                        }
                        
                    }
                    
                }
                
            }
        
       }

       return "";
    }
}    


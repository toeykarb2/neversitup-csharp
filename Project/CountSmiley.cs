
class CountSmiley
{
    public static int FindSmiley(string[] args){
        int count = 0;
        foreach (var item in args)
        {
            Boolean isSmileyWithOutNose = item.Length == 2 ? true : false ;
            Boolean isSmileyWithNose = item.Length == 3 ? true : false ;
            Boolean isEye = item[0] == ':' || item[0] == ';' ? true : false;
            
            if(isSmileyWithOutNose){
            Boolean isMouth = item[1] == ')' || item[1] == 'D' ? true : false;
            if(isEye && isMouth ){
                count++;
            }
            }else if(isSmileyWithNose){
                Boolean isNose = item[1] == '-' || item[1] == '~' ? true : false;
                Boolean isMouth = item[2] == ')' || item[2] == 'D' ? true : false;
                if(isEye && isMouth && isNose){
                count++;
            }

            }
        }
        return count;
    }

  
}
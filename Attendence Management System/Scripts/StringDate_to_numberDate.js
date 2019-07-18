//var str = "1/17/2019";

//console.log( DatetoNumber(str));

function DatetoNumber(str1){
    var count = 0;
    var d="",m="",y="";
    for (var x=0; x< str1.length; x++){
        if(str1.charAt(x) != '/'){
                //console.log(str1.charAt(x));
            if(count == 0)
                m+= str1.charAt(x);
            if(count == 1)
                d+= str1.charAt(x);
            if(count == 2)
                y+= str1.charAt(x);
        }else 
            {
                if(count <= 2)
                    ++count;
                else
                    count=0;	
            }
    }
	return date = [Number(m),Number(d),Number(y)];
}
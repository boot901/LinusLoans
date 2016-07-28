
function removeRow(id,num){
    var table=document.getElementById(id);
    var tbody=table.children[0];
    tbody.removeChild(tbody.childNodes[num]);
    
}
function addElementToRow(id,rowNum,elems,isInnerHtml){
    var table=document.getElementById(id);
    var tbody=table.children[0];
    var row=tbody.children[rowNum];
    
    if(!isInnerHtml){
        var els;
        var d=0;
        var cols=row.children;
        var str;
        while(d<cols.length){
            
                for(var i=0; i<elems.length;i++){
                    str=elems[i][0];
                    els=document.createElement(str);
                    for(var z=0; z<elems[i][1].length; z+=2){
                        
                        els.setAttribute(elems[i][1][z],elems[i][1][z+1]);
                        
                    }
                    
                    cols[d].appendChild(els);
                    d++;
                }
        }
    }
    else
    {
        row.InnerHTML+=elems;
    }
}
function returnRowNum(id){
	var table=document.getElementById(id);
    var tbody=table.children[0];
    return tbody.children.length;
}
function addElementsToCol(id,colNum,rowNum,elems,isInnerHtml){
    var table=document.getElementById(id);
    var tbody=table.children[0];
    var row=tbody.children[rowNum];
     var cols=row.children[colNum];
    if(!isInnerHtml){
        var els;
        var d=0;
       
        var str;
            
                for(var i=0; i<elems.length;i++){
                    str=elems[i][0];
                    els=document.createElement(str);
                    for(var z=0; z<elems[i][1].length; z+=2){
                        
                        els.setAttribute(elems[i][1][z],elems[i][1][z+1]);
                        
                    }
                    
                    cols.appendChild(els);

                }
        
    }
    else
    {
        cols.InnerHTML+=elems;
    }
}
function addRow(id,txt){
    var table=document.getElementById(id);
    var tbody=table.children[0];
    var row=document.createElement("tr");
    var column;
    var node;
    for(var i=0; i<txt.length;i++){
        column=document.createElement("td");
        node=document.createTextNode(txt[i]);
        column.appendChild(node);
        row.appendChild(column);
    }
    tbody.appendChild(row);

}
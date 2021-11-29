var generate = function(numRows) {
    let triangle = [];
    triangle.push([1]);
    for (let i = 0; i < numRows-1; i++) {
        let array = [];
        array.push(1);
        for (let j = 0; j < i; j++) {
            let value = 0;
            value = triangle[i][j] + triangle[i][j+1];
            array.push(value);
        }
        array.push(1);
        triangle.push(array);
    }
    return triangle;
};

console.log( generate(5) );

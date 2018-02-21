const getGets = (arr) => {
    let index = 0;

    return () => {
        const toReturn = arr[index];
        index += 1;
        return toReturn;
    };
};
// this is the test
const test =`8
3
-3
-2
-3
-2
-5
-4
-2
-7`.split('\n')

const gets = this.gets || getGets(test);
const print = this.print || console.log;

var n = parseInt(gets());
var k = parseInt(gets());

var arr = [];
var result = +0;

for (var i = 0; i < n; i += 1) {
    arr[i] = parseInt(gets());
}

arr = arr.sort((a,b) => (+a) - (+b));

for (var i = 0; i < k; i += 1) {
    result += parseInt(arr.pop());
}

print(result);
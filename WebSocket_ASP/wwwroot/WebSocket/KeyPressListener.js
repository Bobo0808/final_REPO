class KeyPressListener {
   constructor(keyCode, callback) {
      let keySafe = true;
      let interval;
      let timeout;
      this.keydownFunction = function (event) {
         if (event.code === keyCode) {
            if (keySafe) {
               keySafe = false;
               callback();
               timeout = setTimeout(function () {
                  interval = setInterval(function () {
                     callback();
                  }, 200)
               }, 0)
            }
         }
      };
      this.keyupFunction = function (event) {
         if (event.code === keyCode) {
            keySafe = true;
            clearInterval(interval);
            clearTimeout(timeout);
         }
      };
      document.addEventListener("keydown", this.keydownFunction);
      document.addEventListener("keyup", this.keyupFunction);
   }

   unbind() {
      document.removeEventListener("keydown", this.keydownFunction);
      document.removeEventListener("keyup", this.keyupFunction);
   }


}
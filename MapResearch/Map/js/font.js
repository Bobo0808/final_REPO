class Sprite {
    constructor({
        position,
        velocity,
        image,
        frames = { max: 1, hold: 10 },
        sprites,
        animate = false,
        rotation = 0,
        scale = 1
    }) {
        this.position = position
        this.image = new Image()
        this.frames = { ...frames, val: 0, elapsed: 0 }
        this.image.onload = () => {
            this.width = (this.image.width / this.frames.max) * scale
            this.height = this.image.height * scale
        }
        this.image.src = image.src

        this.animate = animate
        this.sprites = sprites
        this.opacity = 1

        this.rotation = rotation
        this.scale = scale
    }

    draw() {
        ctx.save()
        ctx.translate(
            this.position.x + this.width / 2,
            this.position.y + this.height / 2
        )
        ctx.rotate(this.rotation)
        ctx.translate(
            -this.position.x - this.width / 2,
            -this.position.y - this.height / 2
        )
        ctx.globalAlpha = this.opacity

        const crop = {
            position: {
                x: this.frames.val * (this.width / this.scale),
                y: 0
            },
            width: this.image.width / this.frames.max,
            height: this.image.height
        }

        const image = {
            position: {
                x: this.position.x,
                y: this.position.y
            },
            width: this.image.width / this.frames.max,
            height: this.image.height
        }

        ctx.drawImage(
            this.image,
            crop.position.x,
            crop.position.y,
            crop.width,
            crop.height,
            image.position.x,
            image.position.y,
            image.width * this.scale,
            image.height * this.scale
        )

        ctx.restore()

        if (!this.animate) return

        if (this.frames.max > 1) {
            this.frames.elapsed++
        }

        if (this.frames.elapsed % this.frames.hold === 0) {
            if (this.frames.val < this.frames.max - 1) this.frames.val++
            else this.frames.val = 0
        }
    }
}


class Boundary {
    static width = 64;
    static height = 64;
    constructor({ position }) {
        //位置相對做標定義
        this.position = position
        //地圖放大200%
        this.width = 64
        this.height = 64
        
        
    }

    draw() {
        // ctx.fillStyle = 'rgba(255, 0, 0, 0)'
        ctx.fillStyle = 'red'
        ctx.fillRect(this.position.x, this.position.y, this.width, this.height)
    }
}

class Character extends Sprite {
    constructor({
        position,
        velocity,
        image,
        frames = { max: 1, hold: 10 },
        sprites,
        animate = false,
        rotation = 0,
        scale = 1,
        dialogue = ['']
    }) {
        super({
            position,
            velocity,
            image,
            frames,
            sprites,
            animate,
            rotation,
            scale
        })

        this.dialogue = dialogue
        this.dialogueIndex = 0
    }
}

let x = 0
let y = 0

// Function to animate background of the Home menu

function moveBackground() {
    document.getElementById("backgroundAnimated").style.backgroundPosition = `${x}px ${y}px `
    x += 1
    y -= 1
}

setInterval(moveBackground, 30)
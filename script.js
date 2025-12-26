const lines = [
    "LOG: Initializing Ghost-Shell...",
    "LOG: Checking GitHub Source Integrity...",
    "LOG: No Binaries Detected. Pure Source Mode Active.",
    "LOG: System Ready."
];

let index = 0;
const output = document.getElementById('output');

function bootSequence() {
    if (index < lines.length) {
        let p = document.createElement('p');
        p.textContent = lines[index];
        p.style.color = "#00ff41";
        output.appendChild(p);
        index++;
        setTimeout(bootSequence, 600);
    }
}
bootSequence();

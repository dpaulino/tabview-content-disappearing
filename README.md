## WinUI TabView sample showing bug with content disappearing on tab rearrange

### Repro steps

1. Clone this repo
1. Open in VS2019 and launch by pressing F5
1. Window opens with two tabviews in the app, one at the top half of the page and another at the bottom half of the page.
    - The top half is a tabview that works fine (content does not disappear on tab rearrange).
    - The bottom half is a tabview that is broken.
1. Test top half
    - Press new tab (+) button twice to open two tabs.
    - Drag and drop to rearrange the tabs. Content does not disappear.
1. Test bottom half
    - Press new tab (+) button twice to open two tabs.
    - Drag and drop to rearrange the tabs
    - Content disappears.
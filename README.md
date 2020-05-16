## WinUI TabView sample showing bug with content disappearing on tab rearrange

Sample video showing bug: https://streamable.com/c4nbil 

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

# Description for disappearingPivot branch

In the `disappearingPivot` branch, I demo a new bug I found where pivots inside a TabView's content will disappear when you rearrange the tabs. **But it only disappears if you drag a tab and hold it for ~3 seconds before you drop it in a different location**. 

### Repro steps
1. Clone this repo
1. Open in VS2019 and launch by pressing F5.
1. Open 2 new tabs using the TabView from the top half of the app.
1. Select one of the tabs
1. Drag the selected tab and hold on to it for at least 3 seconds.
1. Move the tab (while you're holding it) to a different location and then let go to drop it.
1. You'll see that the `Hello` pivots will disappear after dropping.

Sample video: https://streamable.com/mzrxvs
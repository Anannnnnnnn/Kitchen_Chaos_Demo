# Kitchen Chaos Demo

![演示](C:\Users\Anan\Desktop\演示.gif)

这是一个基于  Code Monkey 的教程开发的胡闹厨房模拟游戏。玩家需要在限定时间内根据订单制作食物并交付。

---

## 🚀 技术规格 (Tech Stack)

*   **Unity版本**: `2022.3.5f1` *(请务必在此处填写您正确的Unity版本！)*
*   **渲染管线 (Render Pipeline)**: `通用渲染管线 (URP)`
*   **核心依赖**: 本项目使用 **Git LFS** 来管理大体积的游戏素材，请务必确保已安装。

---

## 🔧 如何开始 (Getting Started)

请严格按照以下步骤操作，以确保项目能成功在您的电脑上运行。

### 1. 先决条件 (Prerequisites)

在克隆项目之前，请确保您的电脑上已经安装了以下软件：

* **Git**: [Git官网下载地址](https://git-scm.com/)

* **Git LFS (Large File Storage)**: 这是**必须**的步骤！如果未安装，您下载的项目将缺少所有模型、贴图和音频文件。

  * 访问 [Git LFS 官网](https://git-lfs.github.com/) 下载并安装。

  * 安装后，打开命令行工具 (Git Bash, Terminal, or CMD) 并运行一次以下命令来初始化Git LFS：

    ```bash
    git lfs install
    ```

* **Unity Hub**: [Unity官网下载地址](https://unity.com/download)

* **Unity Editor**: 请通过 Unity Hub 安装与本项目完全匹配的版本: `2022.3.5f1`。版本不匹配可能会导致项目无法打开或出现大量错误。

### 2. 克隆与设置项目 (Cloning & Setup)

1. **克隆仓库**: 打开您选择的命令行工具，并执行以下命令：

   ```bash
   git clone https://github.com/Anannnnnnnn/Kitchen_Chaos_Demo.git
   ```

   在克隆过程中，您应该会看到下载Git LFS文件的相关日志，例如 `Downloading ...`。这表示LFS正在正常工作。

2. **进入项目目录**:

   ```bash
   cd Kitchen_Chaos_Demo
   ```

3. **(验证步骤)** 如果您不确定LFS文件是否已成功下载，可以手动执行一次拉取命令：

   ```bash
   git lfs pull
   ```

   如果提示所有文件都已是最新，则说明一切正常。

### 3. 在Unity中打开项目 (Opening in Unity)

1. 打开 **Unity Hub**。

2. 在“项目”标签页中，点击“**打开**” (Open) 按钮。

3. 在文件浏览器中，导航到您刚刚克隆的 `Kitchen_Chaos_Demo` 文件夹，并选中它。

4. Unity Hub 会将此项目添加到您的项目列表中。点击它即可开始导入。

   > **请注意**: 首次打开项目时，Unity需要花费较长时间（可能5到30分钟，取决于电脑性能）来重新生成 `Library` 文件夹并导入所有资源。在此期间编辑器可能会看似“无响应”，请耐心等待直至完成。

### 4. 运行游戏 (Running the Game)

1.  当项目成功打开后，在`Project`窗口中找到 `Assets/Scenes` 文件夹。
2.  双击打开 `MainMenuScene` 或主要的游戏场景。
3.  点击Unity编辑器顶部的 **播放 (Play)** 按钮，即可开始游戏！

---

## 📝 给开发者的提示 (Notes for Developers)

*   本项目的 `.gitignore` 文件已配置为忽略Unity自动生成的临时文件（如 `Library`, `Logs`, `Temp` 文件夹）。请不要手动将这些文件夹添加到版本控制中。
*   所有的大文件（图片、模型、音频等）都已通过 `.gitattributes` 文件配置为由Git LFS追踪。如果您添加了新的大文件类型，请记得使用 `git lfs track "*.yourextension"` 命令来添加追踪。
